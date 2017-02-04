using UnityEngine;
using System.Collections;
using System;
using System.Net;
using System.Threading;
using System.IO;
using System.Text;

public class RequestState
{
	// This class stores the State of the request.
	const int BUFFER_SIZE = 1024;
	public StringBuilder requestData;
	public byte[] BufferRead;
	public HttpWebRequest request;
	public HttpWebResponse response;
	public Stream streamResponse;
	public string errorMessage;
	public RequestState()
	{
		BufferRead = new byte[BUFFER_SIZE];
		requestData = new StringBuilder("");
		request = null;
		streamResponse = null;
		errorMessage = null;
	}
}

class TestWebRequest
{
	public static ManualResetEvent allDone= new ManualResetEvent(false);
	const int BUFFER_SIZE = 1024;
	const int DefaultTimeout = 3 * 1000; // 3 minutes timeout
	
	// Abort the request if the timer fires.
	private static void TimeoutCallback(object state, bool timedOut) { 
		Debug.Log("time out call back = " + timedOut);
		if (timedOut) {
			HttpWebRequest request = state as HttpWebRequest;
			if (request != null) {
				request.Abort();
			}
		}
		else
		{
			RegisteredWaitHandle registeredWaitHandle = (RegisteredWaitHandle) state;
			if(registeredWaitHandle != null)
				registeredWaitHandle.Unregister(null);
		}
	}

	public IEnumerator BeginSendAndReceive(string url, System.Action<bool> result)
	{  
		result(false);

			// Create a HttpWebrequest object to the desired URL. 
			HttpWebRequest myHttpWebRequest= (HttpWebRequest)WebRequest.Create(url);

			// object to its request field.  
			RequestState myRequestState = new RequestState();  
			myRequestState.request = myHttpWebRequest;

			// Start the asynchronous request.
	    	Debug.Log("BeginGetResponse");
			IAsyncResult asynResult=
				(IAsyncResult) myHttpWebRequest.BeginGetResponse(new AsyncCallback(RespCallback),myRequestState);
			// this line implements the timeout, if there is a timeout, the callback fires and the request becomes aborted
			ThreadPool.RegisterWaitForSingleObject (asynResult.AsyncWaitHandle, new WaitOrTimerCallback(TimeoutCallback), myHttpWebRequest, DefaultTimeout, true);
			// Wait until the the call is completed
			while (!asynResult.IsCompleted) { yield return null; }

			if (myRequestState.errorMessage != null) {
				if ( myRequestState.errorMessage.Contains("404") || myRequestState.errorMessage.Contains("NameResolutionFailure") ) {
					result(true);
				} else {
					Debug.LogWarning("[WebAsync] Error trying to verify if URL '"+ url +"' exists: "+ myRequestState.errorMessage);
				}
			}
			//allDone.WaitOne();
			// Release the HttpWebResponse resource.
			//myRequestState.response.Close();

	}
	private static void RespCallback(IAsyncResult asynchronousResult)
	{  
		RequestState myRequestState=(RequestState) asynchronousResult.AsyncState;
		try
		{
			HttpWebRequest  myHttpWebRequest=myRequestState.request;
			myRequestState.response = (HttpWebResponse) myHttpWebRequest.EndGetResponse(asynchronousResult);
			
			// Read the response into a Stream object.
			Stream responseStream = myRequestState.response.GetResponseStream();
			myRequestState.streamResponse=responseStream;
			
			// Begin the Reading of the contents of the HTML page and print it to the console.
			//IAsyncResult asynchronousInputRead = responseStream.BeginRead(myRequestState.BufferRead, 0, BUFFER_SIZE, new AsyncCallback(ReadCallBack), myRequestState);
			//return;
		}
		catch(WebException e)
		{
			myRequestState.errorMessage = e.Message;
		}
		//allDone.Set();
	}
	private static  void ReadCallBack(IAsyncResult asyncResult)
	{
		try
		{
			
			RequestState myRequestState = (RequestState)asyncResult.AsyncState;
			Stream responseStream = myRequestState.streamResponse;
			int read = responseStream.EndRead( asyncResult );
			// Read the HTML page and then print it to the console.
			if (read > 0)
			{
				myRequestState.requestData.Append(Encoding.ASCII.GetString(myRequestState.BufferRead, 0, read));
				IAsyncResult asynchronousResult = responseStream.BeginRead( myRequestState.BufferRead, 0, BUFFER_SIZE, new AsyncCallback(ReadCallBack), myRequestState);
				return;
			}
			else
			{
				Debug.Log("The contents of the Html page are : ");
				if(myRequestState.requestData.Length>1)
				{
					string stringContent;
					stringContent = myRequestState.requestData.ToString();
				}
				responseStream.Close();
			}
			
		}
		catch(WebException e)
		{

		}
		//allDone.Set();
		
	}
}
