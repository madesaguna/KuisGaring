using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {
	public GameObject panelGameOver;
	public GameObject panelIngame;


	// Update is called once per frame
	void Update () {
		if (GetComponent<TimeElapsed>().timeEl <= 0) {
			panelGameOver.SetActive (true);
			panelIngame.SetActive (false);

		}
			
	}
}
