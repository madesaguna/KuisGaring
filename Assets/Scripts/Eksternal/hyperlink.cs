using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hyperlink : MonoBehaviour {

	public void openFacebook(){
		Application.OpenURL ("https://www.facebook.com/maenstudio/");
	}

	public void openInstagram(){
		Application.OpenURL ("https://www.instagram.com/maen_studio/");
	}

	public void openTwitter(){
		Application.OpenURL ("http://www.maenstudio.com");
	}
}
