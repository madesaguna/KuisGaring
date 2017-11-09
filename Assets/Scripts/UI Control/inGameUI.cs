using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class inGameUI : MonoBehaviour {
	public Text txtLevel;
	public GameObject panelNotif;

	// Use this for initialization
	void Start () {
		txtLevel.text = "Level : " + (GetComponent<ManagerSoal>().soalTerjawab + 1);
	}
	

	public void backtoMenu(){
		SceneManager.LoadScene (0);
	}
		

	public void reloadGame(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}

	public void ulangSoal(){
		PlayerPrefs.DeleteKey ("SOALTERJAWAB");
		reloadGame ();
	}
}
