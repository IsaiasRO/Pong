using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
	private Rigidbody2D rb;

	// Use this for initialization
	void Start (){
		
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2 (10f,10f);

	}
	void Update(){
		
	}

}
