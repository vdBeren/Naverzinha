using UnityEngine;
using System.Collections;

public class TitleMenuControl : MonoBehaviour {

	public GameObject PanelCredits;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void PlayAction(){
		Debug.Log ("PLAY");
		Application.LoadLevel ("LevelMars");
	}

	public void CreditsAction(bool toggle){
		Debug.Log ("CREDITS");
		PanelCredits.SetActive(toggle);

	}

	public void QuitAction(){
		Debug.Log ("QUIT");
		Application.Quit();
	}
}
