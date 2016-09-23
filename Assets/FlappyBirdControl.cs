using UnityEngine;
using System.Collections;

public class FlappyBirdControl : MonoBehaviour {
	public float jumpValue;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.H)) {
			GetComponent<Rigidbody> ().AddForce(Vector3.up*jumpValue, ForceMode.VelocityChange);
		}
	}
}
