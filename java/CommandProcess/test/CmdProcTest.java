package test;

import java.util.ArrayList;
import sysTools.*;

public class CmdProcTest
{
	public static void main(String[] args)
	{
		ArrayList<String> cmd = new ArrayList<String>();
		int ccSize = 5000;
		TimedDumper d = null;
		CmdProc p = null;
		
		cmd.add("/bin/ls");
		cmd.add("-al");
		cmd.add(".");
		cmd.add("/bin/ls");
		cmd.add("-latr");
		cmd.add(".");
		
		p = new CmdProc(cmd, "/home/ivan", "", ccSize);
		d = new TimedDumper(p.getCommChannel());
		
		ArrayList<String> resp = d.dump();
		
		p.close();
		
		for(String s : resp)
			System.out.println(s);
		
		System.out.println("Starting second pass");
		
		cmd.clear();
		cmd.add("bash");
		cmd.add("-c");
		cmd.add("echo \"Starting cmd 1\";" +
				"ls -al .;" +
				"echo \"Starting cmd 2\";" +
				"ls -latr .;" +
				"echo \"Exiting\"");
		
		p = new CmdProc(cmd, "/home/ivan", "", ccSize);
		d = new TimedDumper(p.getCommChannel());
		
		resp = d.dump();
		
		p.close();
	
		for(String s : resp)
			System.out.println(s);
	}
}
