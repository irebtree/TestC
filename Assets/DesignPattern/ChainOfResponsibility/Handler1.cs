using UnityEngine;
using System.Collections;

public class Handler1 : Handler {

	protected override int GetHandlerLevle ()
	{
		return Levels.LEVEL1;
	}

	protected override void Handle (Request request)
	{
		Debug.Log("处理者-01 处理 " + request.Content() );
	}
}
