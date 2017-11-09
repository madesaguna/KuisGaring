using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeElapsed : MonoBehaviour {
	
	public Text txtTimeEl;
	public float timeEl;

	void Awake(){
		txtTimeEl.text = "" + (int)timeEl;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (timeEl > 0) {
			timeEl -= Time.deltaTime;
			txtTimeEl.text = "" + (int)timeEl;
		} 
	}
}
