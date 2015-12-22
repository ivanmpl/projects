package sysTools;

public class Delay
{
	@SuppressWarnings("static-access")
	public static void delay(int msecs)
	{
		try
		{
			Thread.currentThread().sleep(msecs);
		}
		catch (InterruptedException e)
		{
			// Swallowed Exception
		}
	}
}
