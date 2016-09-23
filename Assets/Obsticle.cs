using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Obsticle : MonoBehaviour {
	public float speed;
	public float death;
	public float timer;
	private float timerValue;
	// Use this for initialization
	void Start () {

		timerValue = timer;

	}
	
	// Update is called once per frame
	void Update () {

		if (death != 0) {
			timerValue -= Time.deltaTime;
		}
		transform.Translate (-Vector3.right*Time.deltaTime*speed);

		if (timerValue <= 0) {
			Destroy (this.gameObject);

		}

	}

	void onCollisionEnter(Collision other) {
		Destroy (other.gameObject);
		Destroy (this.gameObject);
	}


}
