using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	private Vector3 position;
	private Vector2 velocity;
	public float speed;

	public EnemyMovement() {}

	public EnemyMovement(Vector3 position, Vector2 velocity) {
		this.position = position;
		this.velocity = velocity;
	}

	// Use this for initialization
	void Start () {
		if (position == Vector3.zero) {
			transform.position = RandomStartPosition ();
		} else {
			transform.position = position;
		}

		if (velocity == Vector2.zero) {
			velocity = RandomStartVelocity ();
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate (velocity);
	}

	Vector3 RandomStartPosition() {
		// Determine start position
		Vector3 worldSize = Camera.main.ScreenToWorldPoint (new Vector3 ((float)Screen.width, (float)Screen.height, 0.0f));
		float entrySide = Random.value;
		// Random x & y positions are set but may be replaced later.
		float entryPointX = Random.Range(-worldSize.x * 2, worldSize.x * 2);
		float entryPointY = Random.Range(-worldSize.y * 2, worldSize.y * 2);
		
		// Decide from which side the object will enter
		// 0-0.25 top
		// 0.25-0.50 bottom
		// 0.50-0.75 right
		// 0.75-1 left
		if (entrySide <= 0.25f) {
			entryPointY = worldSize.y;
		}
		
		if (entrySide > 0.25f && entrySide <= 0.50f) {
			entryPointY = -worldSize.y;
		}
		
		if (entrySide > 0.50f && entrySide <= 0.75f) {
			entryPointX = worldSize.x;
		}
		
		if (entrySide > 0.75f) {
			entryPointX = -worldSize.x;
		}
		
		return new Vector3 (entryPointX, entryPointY, 0.0f);
	}

	Vector2 RandomStartVelocity() {
		float speedX = ((float) Random.Range(-100, 100) / 1000) * speed;
		float speedY = ((float) Random.Range(-100, 100) / 1000) * speed;
		return new Vector2(speedX, speedY);
	}
}
