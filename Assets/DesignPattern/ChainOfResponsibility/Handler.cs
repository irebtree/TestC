using UnityEngine;
using System.Collections;

public abstract class Handler {

	private Handler nextHandler = null;
	public void SetNextHandler(Handler nextHandler)
	{
		this.nextHandler = nextHandler;
	}

	public void HandleRequest(Request request)
	{
		if(GetHandlerLevle() == request.GetRequestLevel())
		{
			this.Handle(request);
		}
		else
		{
			if(nextHandler != null)
			{
				Debug.Log("当前 处理者-0" + this.GetHandlerLevle()
				          + " 不足以处理 请求-0" + request.GetRequestLevel());
				nextHandler.HandleRequest(request);
			}
			else
				Debug.Log("职责链上的所有处理者都不能胜任该请求...");
		}
	}

	protected abstract int GetHandlerLevle();

	protected abstract void Handle(Request request);
}
