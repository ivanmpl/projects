package sysTools;

import java.util.ArrayList;
import sysTools.CommChannel;
import sysTools.Delay;

public class TimedDumper
{
	private CommChannel cc;
	
	@SuppressWarnings("unused")
	private TimedDumper()
	{ }
	
	public TimedDumper(CommChannel c)
	{
		cc = c;
	}
	
	private String noBlockGetLine()
	{
		String line = null;
		if (cc.look())
			line = cc.get();
		return line;
	}
	
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
}
