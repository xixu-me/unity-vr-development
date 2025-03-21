using UnityEngine;
using System.Collections;

public class TextHintScript : MonoBehaviour {

	// Use this for initialization
	public int fontSizeAddSpeed = 1;
	public float maxShowTime = 3.0f;
	float timer = 0.0f;
	public int maxfontSize = 100;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (guiText.enabled)
		{
			timer += Time.deltaTime;
            if (guiText.fontSize < maxfontSize)
			{
                guiText.fontSize += fontSizeAddSpeed;
            }
            if (timer > maxShowTime)
			{
				guiText.enabled = false;
				timer = 0.0f;
			}
		}
		
	}

	void showTextHint (string text)
	{
		if (!guiText.enabled)
		{
			guiText.enabled = true;
		}
		guiText.text = text;
		timer = 0.0f;
	}
}
