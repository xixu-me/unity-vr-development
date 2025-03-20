using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour {

	public float rotationSpeed = 100.0f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "Player")
		{
			collider.SendMessage("pickup");
            Destroy(this.gameObject);
		}
	}
}
