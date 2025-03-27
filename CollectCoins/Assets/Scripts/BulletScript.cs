using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	public float bulletLifeTime = 10.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine("bulletDestory");
	}

	IEnumerator bulletDestory()
	{
		yield return new WaitForSeconds(bulletLifeTime);
		Destroy(this.gameObject);
	}
}
