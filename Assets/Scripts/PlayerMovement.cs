using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float topSpeed;
	public float currentSpeed;
	public float turnSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		// Should movement be fixed (up, down, left, right) instead of relying on player facing?

		float inputHorizontal = Input.GetAxis ("Horizontal");
		float inputVertical = Input.GetAxis ("Vertical");
		Vector2 acceleration = new Vector2 (inputHorizontal, inputVertical);

		if (rigidbody2D.velocity.y + acceleration.y < topSpeed && 
		    rigidbody2D.velocity.y + acceleration.y > -topSpeed) {
			transform.Translate(0.0f, ((rigidbody2D.velocity.y + acceleration.y) * Time.deltaTime) * topSpeed, 0.0f);
			currentSpeed = rigidbody2D.velocity.y + acceleration.y;
		}

		if (rigidbody2D.velocity.x + acceleration.x < topSpeed && 
		    rigidbody2D.velocity.x + acceleration.x > -topSpeed) {
			transform.Translate(((rigidbody2D.velocity.x + acceleration.x) * Time.deltaTime) * topSpeed, 0.0f, 0.0f);
			currentSpeed = rigidbody2D.velocity.x + acceleration.x;
		}

		// Mouse turn
		float rotationSpeed = turnSpeed * Input.GetAxis("Mouse X");
		transform.Rotate (0.0f, 0.0f, -rotationSpeed);

//		// Makes the player face the mouse position.
//		Vector3 mousePos = Input.mousePosition;
//		mousePos.z = 3.0f;
//		Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePos);
//		lookPos = lookPos - transform.position;
//		test2 = lookPos;
//		if (lookPos.x > 1.5f || lookPos.y > 1.5f || lookPos.x < -1.5f || lookPos.y < -1.5f) {
//			float angle = Mathf.Atan2 (lookPos.y, lookPos.x) * Mathf.Rad2Deg;
//			transform.rotation = Quaternion.AngleAxis (angle - 90.0f, Vector3.forward);
//		}

	}
}
