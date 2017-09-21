﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball: MonoBehaviour {
	[SerializeField]float speed = 2;
	Rigidbody2D rb;
	[SerializeField] UIManager uimanager;
	void Start (){

		rb = GetComponent<Rigidbody2D> ();
		StartCoroutine (Pause ());

	}
	void Update(){
		//ball point left
		if (transform.position.x < -10.8f) {
			transform.position = Vector2.zero;
			rb.velocity = Vector2.zero;
			uimanager.UpdateCounter2();
			StartCoroutine (Pause ());
		}
		//ball point right
		if (transform.position.x > 10.8f) {
			transform.position = Vector2.zero;
			rb.velocity = Vector2.zero;
			uimanager.UpdateCounter1();
			StartCoroutine (Pause ());
		}
	}
	IEnumerator Pause () {
		
		yield return new WaitForSeconds (2f);
		RandownBall ();
	}

	void RandownBall(){
		
		rb.velocity = new Vector2 (8f, 0f);
		//Random Direction
		int xDirection = Random.Range (0, 2);
		int yDirection = Random.Range (0, 3);

		Vector2 launchDirection = new Vector2 ();

		if (xDirection == 0) {
			launchDirection.x = -8f;
		}
		if (xDirection == 1) {
			launchDirection.x = 8f;
		}
		if (yDirection == 0) {
			launchDirection.y = -8f;
		}
		if (yDirection == 1) {
			launchDirection.y = 8f;
		}
		if (yDirection == 2) {
			launchDirection.y = 0;
		}
		//asigna velocidad 
		rb.velocity = launchDirection;

	}
}
