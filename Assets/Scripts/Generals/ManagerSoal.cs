using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerSoal : MonoBehaviour {
	public List<SoalStructure> soal = new List<SoalStructure> ();
	// Use this for initialization
	public Text txtSoal;

	public int indSoal;
	public InputField inpJwb;
	public int soalTerjawab;

	public AudioSource soundSalah;


	void Start(){
		
		soalTerjawab = PlayerPrefs.GetInt ("SOALTERJAWAB");
		if (soalTerjawab + 1 > soal.Count) {
			GetComponent<inGameUI> ().panelNotif.SetActive (true);
			GetComponent<GameOver> ().panelIngame.SetActive (false);
		} else {
			txtSoal.text = "" + soal [soalTerjawab].soal;
		}
	}
		

	public void jawabSoal(){
		if (inpJwb.text.ToLower() == soal [soalTerjawab].jawaban.ToLower()) {
			GetComponent<GameWin> ().panelWinShow (indSoal);
			soalTerjawab++;
			PlayerPrefs.SetInt ("SOALTERJAWAB", soalTerjawab);
			PlayerPrefs.Save ();
		} else {
			//Suara salah
			soundSalah.Play();
		}
	}
}
