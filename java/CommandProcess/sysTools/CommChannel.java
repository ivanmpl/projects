package sysTools;

import java.util.concurrent.LinkedBlockingQueue;

// This Queue Abstraction is here to make the synchronization between the CmdProc threads
// (the Stream Readers) and the thread hosting the CmdProc easier

public class CommChannel
{
	private LinkedBlockingQueue<String> channel = null;
	
	@SuppressWarnings("unused")
	private CommChannel()
	{ }
	
	public CommChannel(int size)
	{
		channel = new LinkedBlockingQueue<String>(size);
	}
	
	// Put a string onto the queue
	// blocks if queue is full
	public void send(String s)
	{
		try
		{
			channel.put(s);
		}
		catch (InterruptedException e)
		{
			e.printStackTrace();
		}
	}
	
	// Get a string out of the queue
	// blocks if queue is empty
	public String get()
	{
		String got = null;
		try
		{
			got = channel.take();
		}
		catch (InterruptedException e)
		{
			e.printStackTrace();
		}
		return got;
	}
	
	// Non-blocking check to see if anything is in the queue
	public boolean look()
	{
		boolean resp = false;
		String temp = channel.peek();
		if (temp != null)
			resp = true;
		return resp;
	}
}
