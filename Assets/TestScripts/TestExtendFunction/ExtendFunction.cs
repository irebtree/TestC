using UnityEngine;
//using System.Collections;
//Extend function must be a static function
public static class ExtendFunction  {

	public static void Test(this string s)
	{
		Debug.Log("mimi ");
	}
}
