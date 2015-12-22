package sysTools;

import java.lang.Process;

import condComp.CondComp;

// Multiple Threads must be used to avoid a deadlock
// A CmdProc is a thread running the shell or remote process
// A CmdMonitor is a separate thread waiting for the remote process to end

public class CmdMonitor extends Thread
{
	private CmdProc cp = null;
	private Process proc = null;
	
	@SuppressWarnings("unused")
	private CmdMonitor()
	{ }
	
	public CmdMonitor(CmdProc c, Process p)
	{
		cp = c;
		proc = p;
	}
	
	public void processEnded(int exitVal)
	{
		cp.processEnded(exitVal);
	}
	
	public void run()
	{
		try
		{
			if (CondComp.debug)
				System.out.println("Waiting for Command to end");
			
			processEnded(proc.waitFor());
		}
		catch (InterruptedException e)
		{
			e.printStackTrace();
		}
	}
}
