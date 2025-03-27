using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour {

	public float rotationSpeed = 100.0f;
	GameObject player;

	void Start () {
		player = GameObject.Find("First Person Controller");
	}
	
	void Update () {
		transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "Player" || collider.gameObject.tag == "Bullet")
		{
            player.SendMessage("pickup");
            Destroy(this.gameObject);
		}
	}
}
