using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {
	[SerializeField] Transform ball;
	[SerializeField] Transform respawn;

	void OnTriggerEnter2D (Collider2D other) {
		
		ball.transform.position = respawn.transform.position;
	}
}
