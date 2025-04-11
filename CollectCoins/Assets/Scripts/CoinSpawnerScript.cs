using UnityEngine;
using System.Collections;

public class CoinSpawnerScript : MonoBehaviour {

	public int maxCoinCount = 8;
	public int minCoinCount = 4;
	public GameObject coinPrefab;
	public float radius = 3f;
	public GameObject floor;
	float floorLength;
	float floorWidth;


	// Use this for initialization
	void Start () {
		floorLength = floor.transform.localScale.x;
		floorWidth = floor.transform.localScale.z;
	}
	
	// Update is called once per frame
	void Update () {
		if (!GameObject.FindGameObjectWithTag("Coin"))
		{
			int count = Random.Range(minCoinCount, maxCoinCount);
			float x = Random.Range(-floorLength / 2, floorLength / 2);
			float z = Random.Range(-floorWidth / 2, floorWidth / 2);
			for (int i = 0;i < count; i++)
			{
				float angle = 2 * Mathf.PI / count * i;
				Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;
				Vector3 center = new Vector3(x, 0, z) + transform.position;
				GameObject coin = Instantiate(coinPrefab, center + pos, Quaternion.Euler(90, 0, 0)) as GameObject;
				coin.transform.SetParent(transform);

				coin.GetComponent<CoinScript>().centerPosition = center;
			}
		}
	}
}
