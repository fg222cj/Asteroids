using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public GameObject Enemy;

	// Use this for initialization
	void Start () {
		for (int x = 0; x < 5; x++) {
			Instantiate(Enemy);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
