using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour {
	public GameObject panelWin;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void panelWinShow(int indSoal){
		GetComponent<GameOver> ().panelIngame.SetActive (false);
		panelWin.SetActive (true);
	}
}
