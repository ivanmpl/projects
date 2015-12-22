package sysTools;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;

import condComp.CondComp;

// A thread to read output from the remote process
// This class puts the output as Strings onto the CommChannel

public class StreamConsumer extends Thread
{
	private InputStream is;
	private InputStreamReader isr;
	private BufferedReader br;
	private String type;
	private CommChannel cc;
	
	@SuppressWarnings("unused")
	private StreamConsumer()
	{ }
	
	public StreamConsumer(InputStream i, String t, CommChannel c)
	{
		is = i;
		type = t;
		cc = c;
	}
	
	public void run()
	{
		try
		{
			isr = new InputStreamReader(is);
			br = new BufferedReader(isr);
			String line = null;
			while (((br != null) && ((line = br.readLine()) != null)))
			{
				if (CondComp.debug)
					System.out.println("Responding: " + type + line);
				cc.send(type + line);
			}
		}
		catch (IOException e)
		{
			e.printStackTrace();
		}
	}
	
	public void close()
	{
		try
		{
			if (is != null)
			{
				is.close();
				is = null;
			}
			if (isr != null)
			{
				isr.close();
				isr = null;
			}
			if (br != null)
			{
				br.close();
				br = null;
			}
		}
		catch (IOException e)
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
