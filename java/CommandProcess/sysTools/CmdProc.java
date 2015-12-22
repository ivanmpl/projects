package sysTools;

import java.io.File;
import java.io.OutputStream;
import java.lang.ProcessBuilder;
import java.util.List;

import condComp.CondComp;

import sysTools.CommChannel;

// Service Class encapsulating and tying together al the threads
// and utilities used to manage a remote process

public class CmdProc
{
	private CmdInput ci = null;
	private StreamConsumer sc = null;
	private RedirectedStreamConsumer rsc = null;
	private ProcessBuilder pb = null;
	private Process p = null;
	private CmdMonitor cm = null;
	private String directory = null;
	private CommChannel cc = null;
	private int exitStatus = -9999;

	//@SuppressWarnings("unused")
	//private String type = null;
	
	@SuppressWarnings("unused")
	private CmdProc()
	{ }
	
	//public CmdProc(List<String> cmd, String dir, String type, CommChannel c)
	public CmdProc(List<String> cmd, String dir, String type, int ccSize)
	{
		//this(cmd, dir, type, c, null);
		this(cmd, dir, type, ccSize, null);
	}
	
	//public CmdProc(List<String> cmd, String dir, String type, CommChannel c, OutputStream redirected)
	public CmdProc(List<String> cmd, String dir, String type, int ccSize, OutputStream redirected)
	{
		directory = dir;
		//this.type = type;
		cc = new CommChannel(ccSize);
		
		pb = new ProcessBuilder(cmd);
		
		if (directory != null)
		{
			File wkdir = new File(directory);
			if (wkdir.exists())
			{
				pb = pb.directory(wkdir);
				File temp = pb.directory();
				String cwd = "Current Working Directory: " + temp.toString();
				if (CondComp.debug)
					System.out.println(cwd);
			}
		}
		else
		{
			String cwd = "Current Working Directory: " + System.getProperty("user.dir");
			if (CondComp.debug)
				System.out.println(cwd);
		}
		
		pb.redirectErrorStream(true);
		
		try
		{
			p = pb.start();
			ci = new CmdInput(p.getOutputStream());
			
			if (redirected != null)
			{
				if (CondComp.debug)
					System.out.println("Creating Redirected Output");
				
				rsc = new RedirectedStreamConsumer(p.getInputStream(), type, cc, redirected);
				sc = null;
				rsc.start();
			}
			else
			{
				sc = new StreamConsumer(p.getInputStream(), type, cc);
				rsc = null;
				sc.start();
			}
			
			cm = new CmdMonitor(this, p);
			cm.start();
		}
		catch (Exception e)
		{
			e.printStackTrace();
		}
	}
	
	public void println(String s)
	{
		if (CondComp.debug)
			System.out.println("Sending Command to Process " + s);
		ci.println(s);
	}
	
	public void processEnded(int exitVal)
	{
		if (CondComp.debug)
			System.out.println("Command Ended with Exit Status: " + exitVal);
		
		exitStatus = exitVal;
	}
	
	public int getExitStatus()
	{
		return exitStatus;
	}
	
	public CommChannel getCommChannel()
	{
		return cc;
	}
	
	public void close()
	{
		try
		{
			if (rsc != null)
			{
				rsc.close();
				rsc = null;
			}
			if (sc != null)
			{
				sc.close();
				sc = null;
			}
			if (ci != null)
			{
				ci.close();
				ci = null;
			}
			if (p != null)
				p.destroy();
		}
		catch (Exception e)
		{
			e.printStackTrace();
		}
	}

	protected void finalize() throws Throwable
	{
		try
		{
			close();
		}
		finally
		{
			super.finalize();
		}
	}
}
