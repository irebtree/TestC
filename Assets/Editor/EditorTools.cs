using UnityEngine;
using System.Collections;
using UnityEditor;
public class EditorTools  {
	[MenuItem("Tools/SelectInfo")]
	static void SelectInfo()
	{
		Debug.Log(Selection.objects.Length + " objects selsct ");
	}

	[MenuItem("Tools/SelectInfo", true)]//判断有效性
	static bool SelectInfoValidator()
	{
		return Selection.objects.Length > 0;
	}
	[MenuItem("Tools/ClearSelected")]
	static void ClearSelected()
	{
		Selection.activeObject = null;
	}

}
