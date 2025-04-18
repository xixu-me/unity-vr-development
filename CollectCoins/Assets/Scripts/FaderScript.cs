using UnityEngine;
using System.Collections;

public class FaderScript : MonoBehaviour {

	public GUITexture loadingGUI;

	void Start () {
		Rect rect = new Rect (-Screen.width * 0.5f, -Screen.height * 0.5f, Screen.width, Screen.height);
		guiTexture.pixelInset = rect;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void showLoading()
	{
		Instantiate(loadingGUI);
	}
}
