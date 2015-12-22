package test;

import java.util.ArrayList;

import sysTools.CmdProc;
import sysTools.CommChannel;

public class CmdProcTest2
{
	@SuppressWarnings("static-access")
	public static void waitFor(CmdProc p)
	{
		while (p.getExitStatus() == -9999)
			
		{
			//System.out.println("Exit Status: " + p.getExitStatus());
			Thread.currentThread().yield();
		}
	}
	
	public static void dump(CommChannel c)
	{
		while (c.look())
		{
			String line = null;
			line = c.get();
			System.out.println(line);
		}
	}
	
	public static void main(String[] args)
	{
		ArrayList<String> cmd = new ArrayList<String>();
		int ccSize = 5000;
		CommChannel cc = null;
		CmdProc p = null;
		
		cmd.add("/bin/ls");
		cmd.add("-al");
		cmd.add(".");
		cmd.add("/bin/ls");
		cmd.add("-latr");
		cmd.add(".");
		
		p = new CmdProc(cmd, "/home/ivan", "", ccSize);
		cc = p.getCommChannel();
		CmdProcTest2.waitFor(p);
		//p.close();
		CmdProcTest2.dump(cc);
		p.close();
		
		System.out.println("Starting second pass");
		
		cmd.clear();
		cmd.add("bash");
		cmd.add("-c");
		cmd.add("echo \"Starting cmd 1\";" +
				"ls -al .;" +
				"echo \"Starting cmd 2\";" +
				"ls -latr .;" +
				"echo \"Exiting\"");
		//cmd.add("echo \"Starting cmd 1\"; ls -al .; echo \"Starting cmd 2\"; ls -latr .;echo \"Exiting\"");
		
		p = new CmdProc(cmd, "/home/ivan", "", ccSize);
		cc = p.getCommChannel();
		CmdProcTest2.waitFor(p);
		//p.close();
		CmdProcTest2.dump(cc);
		p.close();
		
		System.out.println("Starting third pass");
		
		cmd.clear();
		cmd.add("bash");
		cmd.add("-i");

		p = new CmdProc(cmd, "/home/ivan", "", ccSize);
		cc = p.getCommChannel();
		p.println("echo \"Starting cmd 1\"");
		p.println("ls -al .");
		p.println("echo \"Starting cmd 2\"");
		p.println("ls -latr .");
		p.println("echo \"Exiting\"");
		p.println("exit");
		
		CmdProcTest2.waitFor(p);
		//p.close();
		CmdProcTest2.dump(cc);
		p.close();
		
		System.out.println("Starting forth pass");
		
		cmd.clear();
		cmd.add("bash");
		cmd.add("-c");
		cmd.add("bash -i");

		p = new CmdProc(cmd, "/home/ivan", "", ccSize);
		cc = p.getCommChannel();
		p.println("echo \"Starting cmd 1\"");
		p.println("ls -al .");
		p.println("echo \"Starting cmd 2\"");
		p.println("ls -latr .");
		p.println("echo \"Exiting\"");
		p.println("exit");
		
		CmdProcTest2.waitFor(p);
		//p.close();
		CmdProcTest2.dump(cc);
		p.close();
	}
}
