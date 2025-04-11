using UnityEngine;
using System.Collections;

[RequireComponent (typeof(AudioSource))]
public class MainMenuButtonScript : MonoBehaviour {

	public string levelToLoad;
	public Texture2D startTexture;
	public Texture2D rollOverTexture;
	public bool isPlayButton = false;
	public bool isQuitButton = false;
	public AudioClip beep;


	void OnMouseEnter()
	{
		guiTexture.texture = rollOverTexture;
	}

	void OnMouseExit()
	{
		guiTexture.texture = startTexture;
	}

	IEnumerator OnMouseUp()
	{
		audio.PlayOneShot(beep);
		yield return new WaitForSeconds(0.35f);
		if (isQuitButton )
		{
			Application.Quit();
		} else if (isPlayButton )
		{
			Application.LoadLevel(levelToLoad);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
