using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball: MonoBehaviour {
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
		int xDirection = Random.Range (0, 2);
		int yDirection = Random.Range (0, 3);
		//launchdirection
		Vector2 BallDirection = new Vector2 ();

		if (xDirection == 0) {
			BallDirection.x = -8f;
		}
		if (xDirection == 1) {
			BallDirection.x = 8f;
		}
		if (yDirection == 0) {
			BallDirection.y = -8f;
		}
		if (yDirection == 1) {
			BallDirection.y = 8f;
		}
		if (yDirection == 2) {
			BallDirection.y = 0;
		}
		rb.velocity = BallDirection;

	}
}
