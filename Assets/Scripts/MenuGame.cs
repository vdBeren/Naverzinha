using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuGame : MonoBehaviour {
	public GameObject PanelHUD;
	public Text PontoText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		PontoText.text = MainScript.Pontos.ToString ();
		if (Input.GetKeyDown(KeyCode.Escape)) {
			PanelHUD.SetActive(true);
			print("Apertou esc");
			Time.timeScale=0.0001f;
		}
	}
	public void ReturnGame(){
		Time.timeScale=1f;
		PanelHUD.SetActive(false);
	}
	public void ReturnMenu(){
		Time.timeScale=1f;
		Application.LoadLevel("Menu");
	}
}
