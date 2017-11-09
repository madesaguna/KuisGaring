using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class homeGameUI : MonoBehaviour {
	public GameObject panelInfo, panelHome;
	// Use this for initialization

	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			exitGame ();
		}
	}

	public void Mainkan(){
		SceneManager.LoadScene (1);
	}


	public void Info(){
		panelHome.SetActive (false);
		panelInfo.SetActive (true);
	}
		

	public void homeShow(){
		panelHome.SetActive (true);
		panelInfo.SetActive (false);
	}

	public void exitGame(){
		Debug.Log ("Keluar");
		Application.Quit ();
	}
}
