using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadObjectFromBundle : MonoBehaviour
{
    public string url;

    public void DownloadModelOnClick()
    {
        StartCoroutine("DownloadObject");
        Debug.Log("Clicked Button");

    }

 //   void Start ()
	//{
	//    StartCoroutine("DownloadObject");
	//}

    IEnumerator DownloadObject()
    {

        WWW www = new WWW(url);
        yield return www;
        AssetBundle assetBundle = www.assetBundle;
        // I have a DemoScene Prefab inside my already created "room" AssetBundle
        GameObject g = Instantiate(assetBundle.LoadAsset("DemoScene")) as GameObject;
    }
}
