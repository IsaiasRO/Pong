using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class controller: MonoBehaviour {
	[SerializeField]  Transform leftPaddle;
	[SerializeField]  Transform rightPaddle;
	[SerializeField] int speed = 4;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)&& leftPaddle.position.y<3.7) {
			//move paddle 1
			leftPaddle.Translate(Vector2.up * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.S)&& leftPaddle.position.y>-3.7) {
			//move paddle 1
			leftPaddle.Translate(Vector2.down * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.UpArrow)&& rightPaddle.position.y<3.7) {
			//move paddle 2
			rightPaddle.Translate(Vector2.up * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.DownArrow)&& rightPaddle.position.y>-3.7) {
			//move paddle 2
			rightPaddle.Translate(Vector2.down * Time.deltaTime * speed);
		}
	}
}
