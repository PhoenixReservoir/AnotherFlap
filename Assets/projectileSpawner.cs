using UnityEngine;
using System.Collections;

public class projectileSpawner : MonoBehaviour {
	public GameObject obstaclePrefab;
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.F)) {
			
			GameObject.Instantiate (obstaclePrefab, transform.position + Vector3.right * speed, Quaternion.identity);
		}
	}
}
