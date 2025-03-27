using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {

	public Rigidbody bullet;
	public float force = 1000f;
	public AudioClip fireSound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		// 检测鼠标左键单击
		if (Input.GetButtonDown("Fire1"))
		{
			Rigidbody b = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
			b.AddForce(transform.forward * force);
			AudioSource.PlayClipAtPoint(fireSound, transform.position);
		}
	}
}
