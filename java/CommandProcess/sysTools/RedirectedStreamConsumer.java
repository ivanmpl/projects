package sysTools;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;
import java.io.PrintWriter;

import condComp.CondComp;


public class RedirectedStreamConsumer extends Thread
{
	private InputStream is = null;
	private InputStreamReader isr = null;
	private BufferedReader br = null;
	private String type = null;
	private OutputStream os = null;
	private PrintWriter pw = null;
	private CommChannel cc = null;
	
	@SuppressWarnings("unused")
	private RedirectedStreamConsumer()
	{ }
	
	public RedirectedStreamConsumer(InputStream i, String t, CommChannel c)
	{
		this(i, t, c, null);
	}
	
	public RedirectedStreamConsumer(InputStream i, String t, CommChannel c, OutputStream o)
	{
		is = i;
		os = o;
		type = t;
		cc = c;
	}
	
	public void run()
	{
		try
		{
			if (os != null)
				pw = new PrintWriter(os);
			
			isr = new InputStreamReader(is);
			br = new BufferedReader(isr);
			String line = null;
			while ((line = br.readLine()) != null)
			{
				if (pw != null)
					pw.println(line);
				if (CondComp.debug)
					System.out.println(type + line);
				cc.send(line);
			}
			if (pw != null)
				pw.flush();
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
			if (os != null)
			{
				os.close();
				os = null;
			}
			if (pw != null)
			{
				pw.close();
				pw = null;
			}
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
