using UnityEngine;
using System.Collections;

public class spawner : MonoBehaviour {
	public float timer;
	private float timerValue;
	public GameObject obstaclePrefab;
	// Use this for initialization
	void Start () {
		timerValue = timer;
	}
	
	// Update is called once per frame
	void Update () {
		timerValue -= Time.deltaTime;
		if (timerValue <= 0) {
			timerValue = timer;
			GameObject.Instantiate (obstaclePrefab, transform.position + Vector3.up * Random.Range (-2f, 2f), Quaternion.identity);
		}
	}
}
