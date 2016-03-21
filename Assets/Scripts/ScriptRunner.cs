using UnityEngine;
using System.Collections;

public class ScriptRunner : MonoBehaviour {

	public static float distanceTraveled;
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0f, 5f * Time.deltaTime, 0f);
		distanceTraveled = transform.localPosition.y;
	}
}
