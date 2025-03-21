using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour {

	public float rotationSpeed = 100.0f;
	public GUIText coinGUIText;

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
			// 触发显示金币数量
			coinGUIText.SendMessage("showTextHint", InventoryScript.coinCount.ToString());
			// 显示左下角图片和数量
			collider.SendMessage("showCoinCount");
		}
	}
}
