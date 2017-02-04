using UnityEngine;
using System.Collections;
using System.IO;
public class TestDownload : MonoBehaviour {
	string url = "http://192.168.1.26/ipad2.mov";
	string fileName = "ipad2.mov";
	string dataPath ;
	string assetPath ;
	// Use this for initialization
	void Start () {
		dataPath = Application.persistentDataPath + "/";
		//dataPath = Application.streamingAssetsPath;
		Debug.Log(dataPath + fileName);
		assetPath = "file:/" + dataPath;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void TesDownload()
	{
		StartCoroutine(DownLoad());
	}

	IEnumerator DownLoad()
	{
		WWW www = new WWW(url);
		yield return www;

		if(www.isDone)
		{
			Debug.Log(www.isDone);
		}
		if(!Directory.Exists(dataPath))
			Directory.CreateDirectory(dataPath);

		System.IO.File.WriteAllBytes(dataPath + fileName,www.bytes);
		Debug.Log("write file ");
	}

	public void PlayMovie()
	{
		Handheld.PlayFullScreenMovie(fileName,Color.black, FullScreenMovieControlMode.CancelOnInput);
	}
}
