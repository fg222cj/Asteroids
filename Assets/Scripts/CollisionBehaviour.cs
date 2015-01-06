using UnityEngine;
using System.Collections;

public class CollisionBehaviour : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D coll) {
		switch (coll.gameObject.tag) {
			case "Player":
				Destroy (coll.gameObject);
				break;
			case "Shot":
				Destroy(gameObject);
				break;
		}

	}

//	void OnCollisionEnter2D(Collision2D coll) {
//		print ("collision detected");
//		switch (coll.gameObject.tag) {
//			case "Enemy":
//				Destroy(gameObject);
//				break;
//		}
//	}
}
