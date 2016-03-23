using UnityEngine;
using System.Collections;

public class ScriptRunner : MonoBehaviour {

	public static float distanceTraveled;
	private bool enAire = true;
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0f, 5f * Time.deltaTime, 0f);
		distanceTraveled = transform.localPosition.y;

		if (enAire) {
			//GetComponent<Rigidbody2D>().AddForce (transform.right * 2);
			transform.Translate(Vector3.right * 2 * Time.deltaTime);
		}

	}

	void OnCollisionEnter2D(){
		enAire = false;
	}
	void OnCollisionExit2D(){
		enAire = true;
	}
}
