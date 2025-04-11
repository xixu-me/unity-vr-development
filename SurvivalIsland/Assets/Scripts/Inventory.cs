using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{

	public static int charge = 0;
	public AudioClip collectSound;
	public Texture2D[] hudCharge;
	public GUITexture chargeHudGUI;

	public Texture2D[] meterCharge;
	public Renderer meter;

	bool haveMatches = false;
	public GUITexture matchGUIprefab;
	GUITexture matchGUI;
	public GUIText textHints;
	bool fireIsLit = false;

	// Use this for initialization
	void Start()
	{
		charge = 0;
	}

	// Update is called once per frame
	void Update()
	{

	}

	void CellPickup()
	{
		HUDon();
		AudioSource.PlayClipAtPoint(collectSound, transform.position);

		charge++;
		chargeHudGUI.texture = hudCharge[charge];
		meter.material.mainTexture = meterCharge[charge];
	}

	void HUDon()
	{
		if (!chargeHudGUI.enabled)
		{
			chargeHudGUI.enabled = true;
		}
	}

	void MatchPickup()
	{
		haveMatches = true;
		//AudioSource.PlayClipAtPoint (collectSound, transform.position);
		GUITexture matchHUD = Instantiate(matchGUIprefab,
										   new Vector3(0.15f, 0.1f, 0), transform.rotation) as GUITexture;
		matchGUI = matchHUD;
	}

	void OnControllerColliderHit(ControllerColliderHit col)
	{
		if (col.gameObject.name == "campfire")
		{
			if (haveMatches && !fireIsLit)
			{
				LightFire(col.gameObject);
			}
			else if (!haveMatches && !fireIsLit)
			{
				textHints.SendMessage("ShowHint",
									  "I could use this campfire to signal for help... " +
									  "if only I could light it...");
			}
		}
	}

	void LightFire(GameObject campfire)
	{
		ParticleSystem[] pSystems;
		pSystems = campfire.GetComponentsInChildren<ParticleSystem>();
		foreach (ParticleSystem pSystem in pSystems)
		{
			pSystem.Play();
		}
		//campfire.audio.Play ();
		Destroy(matchGUI);
		haveMatches = false;
		fireIsLit = true;
	}
}
