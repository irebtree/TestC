using UnityEngine;
using System.Collections;
using UnityEditor;
[CustomEditor(typeof(CustomInspector2))][CanEditMultipleObjects]
public class CustomInspector2Editor : Editor  {


	SerializedProperty serProp;

	GUIContent icon;

	void OnEnable(){
		icon = new GUIContent("myStr",  (Texture2D) AssetDatabase.LoadAssetAtPath("Assets/Resources/icon.jpg", typeof(Texture2D)), "tool tip");
	}

	public override void OnInspectorGUI ()
	{
		serializedObject.Update();

		serProp = serializedObject.GetIterator();

		//var ttt = serializedObject.FindProperty("myStr");
		//Debug.Log(ttt.stringValue);

		serProp.NextVisible(true);
		do{
			if(serProp.name == "myStr")
			{
				EditorGUILayout.TextField(icon,serProp.stringValue);
			}

			else
				EditorGUILayout.PropertyField(serProp);
		}while( serProp.NextVisible(false));
		
		


		serializedObject.ApplyModifiedProperties();
	}
}
