using UnityEngine;
using System.Collections;

public class DoorManager : MonoBehaviour
{
	bool doorIsOpen = false;
	float doorTimer = 0.0f;
	public float doorOpenTime = 3.0f;
	public AudioClip doorOpenSound;
	public AudioClip doorShutSound;


	// Use this for initialization
	void Start()
	{
		doorTimer = 0.0f;
	}

	// Update is called once per frame
	void Update()
	{
		if (doorIsOpen)
		{
			doorTimer += Time.deltaTime;

			if (doorTimer > doorOpenTime)
			{
				Door(doorShutSound, false, "doorshut");
				doorTimer = 0.0f;
			}
		}
	}

	void DoorCheck()
	{
		if (!doorIsOpen)
		{
			Door(doorOpenSound, true, "dooropen");
		}
	}

	void Door(AudioClip aClip, bool openCheck, string animName)
	{
		audio.PlayOneShot(aClip);
		doorIsOpen = openCheck;
		transform.parent.animation.Play(animName);

	}
}

