using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour {

	public float rotationSpeed = 100.0f;
	GameObject player;
	public float rotationCenterSpeed = 50f;
	public Vector3 centerPosition;
	private Color startColor;
	public float colorChangeSpeed = 0.1f;

	void Start () {
		player = GameObject.Find("First Person Controller");
		startColor = renderer.material.color;
	}
	
	void Update () {
		transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);

		transform.RotateAround(centerPosition, Vector3.up, Time.deltaTime * rotationCenterSpeed);

		float change = Mathf.PingPong(colorChangeSpeed * Time.time, 1f);
		Color newColor = Color.Lerp(startColor, Color.red, change);
		renderer.material.color = newColor;
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
