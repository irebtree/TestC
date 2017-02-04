using UnityEngine;
using System.Collections;
using UnityEditor;
[CustomEditor(typeof(CustomInspector))]
public class CustomInspectorEditor : Editor {

	CustomInspector ci;
	GUIContent curContent = new GUIContent();

	protected SerializedProperty myFloat;

	void OnEnable()
	{
		ci = (CustomInspector) target;

		myFloat = this.serializedObject.FindProperty("myFloat");
	}

	public override void OnInspectorGUI ()
	{
		this.serializedObject.Update();
		//DrawDefaultInspector();
		EditorGUI.BeginChangeCheck();
		curContent.image = (Texture2D) Resources.Load("icon");
		curContent.text = "My Int ";
		EditorGUILayout.LabelField("My Editor");
		ci.myInt = EditorGUILayout.IntField(curContent , ci.myInt);

		curContent.text = "My Float";
		EditorGUILayout.PropertyField(myFloat,curContent);

		curContent.text = "Button";
		GUILayout.Button(curContent,GUILayout.MaxWidth(100f),GUILayout.MaxHeight(50));

		GUILayout.Space(10);
		ci.showList = EditorGUILayout.Foldout(ci.showList, "Show list");

		serializedObject.ApplyModifiedProperties();

		//if (GUI.changed)
		//	EditorUtility.SetDirty(target);
		if(EditorGUI.EndChangeCheck())
		{
			Undo.RecordObject(target, "undo myChange" );
			EditorUtility.SetDirty(target);
		}
	
	}
}
