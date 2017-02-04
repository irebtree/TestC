using UnityEngine;
using System.Collections;

public class Handler2 : Handler {

	protected override int GetHandlerLevle ()
	{
		return Levels.LEVEL2;
	}

	protected override void Handle (Request request)
	{
		Debug.Log("处理者-02 处理 " + request.Content() );
	}
}
