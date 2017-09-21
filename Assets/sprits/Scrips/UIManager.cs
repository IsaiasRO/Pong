using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
	[SerializeField] Text Setcounter1;
	[SerializeField] Text Setcounter2;
	int counter = 0;
	int counter2 = 0;

	void Start () {
		
	}
	public void UpdateCounter1 () {
		counter += 1;
		Setcounter1.text = "" +counter; 
	}
	public void UpdateCounter2 () {
		counter2 += 1;
		Setcounter2.text = "" + counter2; 
	}
}
