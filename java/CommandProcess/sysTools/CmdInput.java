package sysTools;

import java.io.IOException;
import java.io.OutputStream;
import java.io.PrintWriter;

// While called CmdInput, it is really an OutStream that we write to the remote process on
// This class is an OutputStream connected to the InputStream of the remote process

public class CmdInput
{
	private OutputStream os;
	private PrintWriter pw;
	
	@SuppressWarnings("unused")
	private CmdInput()
	{ }
	
	public CmdInput(OutputStream o)
	{
		os = o;
		pw = new PrintWriter(os, true);
	}
	
	// Write buffered commands to the remote process stdin
	public void println(String s)
	{
		pw.println(s);
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
