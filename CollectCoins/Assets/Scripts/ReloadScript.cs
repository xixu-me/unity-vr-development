using UnityEngine;
using System.Collections;

public class ReloadScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void loadMenu()
	{
		Application.LoadLevel("menu");
		InventoryScript.coinCount = 0;
	}
}
