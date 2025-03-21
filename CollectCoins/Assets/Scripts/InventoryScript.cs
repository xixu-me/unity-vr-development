using UnityEngine;
using System.Collections;

public class InventoryScript : MonoBehaviour {

	// Use this for initialization
	public AudioClip pickupSound;
	public static int coinCount = 0;
	public GUIText coinCountText;
	public GUITexture coinPic;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void pickup()
	{
		AudioSource.PlayClipAtPoint(pickupSound, transform.position);
		coinCount++;
	}

	void showCoinCount()
	{
		if (!coinPic.enabled)
		{
			coinPic.enabled = true;
			coinCountText.enabled = true;
		}
		coinCountText.text = coinCount.ToString();
	}
}
