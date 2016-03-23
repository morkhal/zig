using UnityEngine;
using System.Collections;

public class Magnet : MonoBehaviour {
	private bool inside;

	void Start(){
		inside = false;
	}

	void FixedUpdate(){
		if (!inside)
			transform.Translate (0f, 5f * Time.deltaTime, 0f); //move normally when not inside the Magnet (insert whatever you use to move the coins)
		else if(inside){ //when inside the Magnet apply magnet's forces
			Vector2 direction = (transform.position - GameObject.Find("paredLarga").transform.position).normalized; //find the direction to move
			float travelSpeed = Vector2.Distance(transform.position, GameObject.Find("paredLarga").transform.position); //set the speed of the score bubble to the distance between it and the player
			//rigidbody2D.AddForce(-direction * travelSpeed); //apply force (This works but can sometimes cause the coins/objects to orbit your player forever
			GetComponent<Rigidbody2D>().velocity = -direction * travelSpeed; //set velocity instead of apply force to avoid orbiting scenarios
		}
	}

	void OnTriggerEnter2D(Collider2D other){ //score bubble is set to isTrigger (when it enters another collider this is run)
		if(other.gameObject.tag =="Derecha"){ //if inside the magnet
			inside =true;
		}else inside = false; //omit this line if you want the coins to only be attracted to your object while within the magnet. I found this line to be unnecessary for gameplay. 
	}
}
