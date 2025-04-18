using UnityEngine;
using System.Collections;

public class WinScript : MonoBehaviour {

	public GUITexture winGUI;
	public AudioClip winSound;
	public GUITexture fader;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator gameOver()
	{
		AudioSource.PlayClipAtPoint(winSound, transform.position, 0.1f);
		Instantiate(winGUI);

		yield return new WaitForSeconds(5.0f);

		Instantiate(fader);
	}
}
