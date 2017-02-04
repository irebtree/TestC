using UnityEngine;
using System.Collections;
using System.IO;
public class TestLoadFromCacheOrDownload : MonoBehaviour {
	public string path ="" ;
	// Use this for initialization
	void Start () {
		//StartCoroutine(Test());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Test()
	{
		WWW www = WWW.LoadFromCacheOrDownload(path,1);
		yield return www;
		byte[] by = www.bytes;
		ByteReader reader = new ByteReader(by);
		string result = reader.ReadLine();
		Debug.Log(result);
	}
}
