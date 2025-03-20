using UnityEngine;
using System.Collections;

public class InventoryScript : MonoBehaviour {

	// Use this for initialization
	public AudioClip pickupSound;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void pickup()
	{
		AudioSource.PlayClipAtPoint(pickupSound, transform.position);
	}
}
