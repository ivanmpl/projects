package test;

import java.util.ArrayList;

import sysTools.CmdProc;
import sysTools.CommChannel;
import sysTools.PromptWatcher;

public class CmdProcTest3
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
		PromptWatcher pt = null;
		//PromptWatcher pt = new PromptWatcher(cc);
		
		cmd.add("/bin/ls");
		cmd.add("-al");
		cmd.add(".");
		cmd.add("/bin/ls");
		cmd.add("-latr");
		cmd.add(".");
		
		p = new CmdProc(cmd, "/home/ivan", "", ccSize);
		cc = p.getCommChannel();
		
		CmdProcTest3.waitFor(p);
		CmdProcTest3.dump(cc);
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
		
		CmdProcTest3.waitFor(p);
		CmdProcTest3.dump(cc);
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
		
		CmdProcTest3.waitFor(p);
		CmdProcTest3.dump(cc);
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
		
		CmdProcTest3.waitFor(p);
		CmdProcTest3.dump(cc);
		p.close();
		
		System.out.println("Starting fifth pass");
		
		cmd.clear();
		cmd.add("bash");
		cmd.add("-i");

		p = new CmdProc(cmd, "/home/ivan", "", ccSize);
		cc = p.getCommChannel();
		pt = new PromptWatcher(cc);
		
		ArrayList<String> resp;
		
		// Set the prompt
		pt.setPrompt("^REMOTE:>$");
		p.println("PS1=\"REMOTE:>\"");
		p.println("\n");
		resp = pt.watchForPrompt();
		for (String line : resp)
			System.out.println(line);
		
		p.println("echo \"Starting cmd 1\"");
		p.println("\n");
		resp = pt.watchForPrompt();
		for (String line : resp)
			System.out.println(line);
		
		p.println("ls -al .");
		p.println("\n");
		resp = pt.watchForPrompt();
		for (String line : resp)
			System.out.println(line);
		
		p.println("echo \"Starting cmd 2\"");
		p.println("\n");
		resp = pt.watchForPrompt();
		for (String line : resp)
			System.out.println(line);
		
		p.println("ls -latr .");
		p.println("\n");
		resp = pt.watchForPrompt();
		for (String line : resp)
			System.out.println(line);
		
		p.println("echo \"Exiting\"");
		p.println("\n");
		resp = pt.watchForPrompt();
		for (String line : resp)
			System.out.println(line);
		
		p.println("exit");
		
		CmdProcTest3.waitFor(p);
		CmdProcTest3.dump(cc);
		p.close();
	}
}
