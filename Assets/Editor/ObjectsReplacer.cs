using UnityEngine;
using System.Collections;
using UnityEditor;
public class ObjectsReplacer : ScriptableWizard {

	public GameObject replacement;
	public bool showDialogs = true;

	public static string strShowDialogKey = "ObjectReplacer.showDialogs";

	[MenuItem("Tools/ObjectsReplacer")]
	static void CreatWizard()
	{
		ScriptableWizard.DisplayWizard("ObjectReplacer", typeof(ObjectsReplacer), "Replace and close", "Replace");
	}

	void OnEnable(){
		showDialogs = EditorPrefs.GetBool(strShowDialogKey, true);
	}

	// called by "Replace and close" button
	void OnWizardCreate(){
		if(errorString != "")
			return;
		DoReplaceAll();
	}
	//called by "Replace" button
	void OnWizardOtherButton()
	{
		if(errorString != "")
			return;
		DoReplaceAll();
	}

	void OnWizardUpdate(){

		Transform[] transforms = Selection.GetTransforms(SelectionMode.TopLevel | SelectionMode.ExcludePrefab);
		helpString = transforms.Length + " items selected for replacement .";
		errorString = "";
		isValid = true;
		if(replacement == null)
		{
			errorString += "No replacement object selected ! \n";
			isValid = false;
		}
		
		if(transforms.Length <1)
		{
			errorString += "No objects selected fo replacement. ";
			isValid = false;
		}

		EditorPrefs.SetBool(strShowDialogKey,showDialogs);
	}
	
	void OnSelectionChange(){
		OnWizardUpdate();
	}

	void DoReplaceAll()
	{
		if(showDialogs)
		{
			if(!EditorUtility.DisplayDialog("Are you sure?", "Are you sure you wish to replace all the selected objects with \"" + replacement.name + "\"?", "Yes", "Cancel"))
				return;
		}

		Transform[] transforms = Selection.GetTransforms(SelectionMode.TopLevel | SelectionMode.ExcludePrefab);
		int count = 0;
		foreach(Transform t in transforms)
		{
			if(EditorUtility.DisplayCancelableProgressBar("Working...", "replacing " + t.name, (float) count/transforms.Length))
				break;
			ReplaceObject(t);
			++count;
		}

		EditorUtility.ClearProgressBar();

		ShowNotification(new GUIContent("Done ! "));

		if(showDialogs)
			EditorUtility.DisplayDialog("Finish replacing!", count + " objects were successfully replaced!", "Ok");
	}

	void ReplaceObject(Transform trans)
	{
		GameObject newGo;
		newGo = PrefabUtility.InstantiatePrefab(replacement) as GameObject;

		newGo.transform.position = trans.position;
		newGo.transform.rotation = trans.rotation;
		newGo.transform.localScale = trans.localScale;
		newGo.transform.parent = trans.parent;

		Undo.RegisterCreatedObjectUndo(newGo,"ReplaceObject");
		Undo.DestroyObjectImmediate(trans.gameObject);
	}


}
