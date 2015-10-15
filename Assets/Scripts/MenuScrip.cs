using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MenuScrip : MonoBehaviour {
	public Text PontoText;
	void Start (){
		if(PontoText)
		PontoText.text = MainScript.Pontos.ToString ();
	}
	public void StartGame(){

		Application.LoadLevel("Level1");
	}
	public void Options(){
		
		Application.LoadLevel("Options");
	}
	public void Quit(){
		
		Application.Quit ();
	}
	public void Menu(){
		
		Application.LoadLevel("Menu");
	}
}
