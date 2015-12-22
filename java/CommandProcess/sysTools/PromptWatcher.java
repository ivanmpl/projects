package sysTools;

import java.util.ArrayList;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import condComp.CondComp;
import sysTools.CommChannel;

// Service Class that watches for a particular patter (a prompt)
// used to monitor the output stream from a remote process
// looking for an indication taht the last command has ended

public class PromptWatcher
{
	private String prompt;
	private Pattern pat;
	private Matcher mat;
	private CommChannel cc;
	
	@SuppressWarnings("unused")
	private PromptWatcher()
	{ }
	
	public PromptWatcher(CommChannel c)
	{
		cc = c;
	}
	
	// What to watch for
	public void setPrompt(String p)
	{
		if (CondComp.debug)
			System.out.println("Setting Prompt to: " + p);
		prompt = p;
		pat = Pattern.compile(prompt);
	}
	
	// A non-blocking get from the CommChannel
	private String noBlockGetLine()
	{
		String line = null;
		if (cc.look())
			line = cc.get();
		return line;
	}
	
	// A blocking get from the CommChannel
	private String blockGetLine()
	{
		String line = cc.get();
		return line;
	}
	
	// A utility to dump whatever is coming back from the process
	public ArrayList<String> dump()
	{
		ArrayList<String> resp = new ArrayList<String>();
		int miss = 0;
		int max = 500;
		String line;
		while (miss < max)
		{
			if ((line = noBlockGetLine()) != null)
			{
				miss = 0;
				resp.add(line);
			}
			else
			{
				miss += 1;
				Delay.delay(2);
			}
		}
		return resp;
	}
	
	// A utility method that sets the pattern and does a watch
	public ArrayList<String> watchForPrompt()
	{
		String line;
		ArrayList<String> resp = new ArrayList<String>();
		while(true)
		{
			line = blockGetLine();
			resp.add(line);
			mat = pat.matcher(line);
			if (CondComp.debug)
				System.out.println("Checking Match on: " + "|" + line + "|");
			if (mat.find())
			{
				if (CondComp.debug)
					System.out.println("Matched");
				break;
			}
		}
		return resp;
	}
}
