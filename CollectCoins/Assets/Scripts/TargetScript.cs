using UnityEngine;
using System.Collections;

public class TargetScript : MonoBehaviour {

	bool beenDown = false;
	Animation targetRoot;
	public float recoveryTime = 5.0f;
	GameObject player;
	void Start () {
		targetRoot = transform.parent.transform.parent.animation;
        player = GameObject.Find("First Person Controller");

    }
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		if (!beenDown && collision.gameObject.tag == "Bullet")
		{
			StartCoroutine("targetHit");
			player.SendMessage("pickup");
		}
	}

	/// <summary>
	/// 击中靶子
	/// </summary>
	/// <returns></returns>
	IEnumerator targetHit()
	{
        targetRoot.Play("down");
		beenDown = true;

		yield return new WaitForSeconds(recoveryTime);

        targetRoot.Play("up");
		beenDown = false;
	}
}
