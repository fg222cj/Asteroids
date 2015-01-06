using UnityEngine;
using System.Collections;

public class BodyBehaviour : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 worldSize = Camera.main.ScreenToWorldPoint (new Vector3 ((float)Screen.width, (float)Screen.height, 0.0f));
		Vector3 viewportPosition = Camera.main.WorldToViewportPoint(transform.position);
		Vector3 newPosition = transform.position;

		
		if (viewportPosition.x > 1)
		{
			newPosition.x -= worldSize.x * 2;
		}

		if (viewportPosition.x < 0)
		{
			newPosition.x += worldSize.x * 2;
		}
		
		if (viewportPosition.y > 1)
		{
			newPosition.y -= worldSize.y * 2;
		}

		if (viewportPosition.y < 0)
		{
			newPosition.y += worldSize.y * 2;
		}
		
		transform.position = newPosition;
	}
}
