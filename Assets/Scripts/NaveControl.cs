using UnityEngine;
using System.Collections;

public class NaveControl : MonoBehaviour {
	public float deslocX,deslocY;
	float aguloH=0;
	float aguloV=0;
	public ParticleSystem Tiro;
	public bool endGame=false;
	// Use this for initialization
	void Start () {
	
	}
	void EndGame(){
		Application.LoadLevel ("Fim");
	}
	// Update is called once per frame
	void Update () {
		if (endGame) {
			EndGame();
		}
		Tiro.emissionRate=0;
		if (Input.GetKey (KeyCode.Space)) {
			Tiro.emissionRate=10;

		}
		if (Input.GetKey (KeyCode.D)) {

			//interpola para -45
			aguloH = Mathf.Lerp (aguloH, 70, Time.deltaTime*5);
		}
		if (Input.GetKey (KeyCode.A)) {

			aguloH = Mathf.Lerp (aguloH, -70, Time.deltaTime*5);
		}
		if (Input.GetKey (KeyCode.W)) {
			
			//interpola para -45
			aguloV = Mathf.Lerp (aguloV, 50, Time.deltaTime*5);
		}
		if (Input.GetKey (KeyCode.S)) {
			
			aguloV = Mathf.Lerp (aguloV, -50, Time.deltaTime*5);
		}


		deslocX = Mathf.Clamp (deslocX, -50, 50);
		deslocX += aguloH * 2f* Time.deltaTime;//pega 2% da forca

		deslocY = Mathf.Clamp (deslocY, -40, 40);
		deslocY += aguloV * 2f* Time.deltaTime;//pega 2% da forca

		transform.localPosition = new Vector3 (deslocX, deslocY, 56);
		transform.localRotation = Quaternion.Euler (-aguloV, aguloH, -aguloH);

		//interpola a variavel para 0
		//deslocX = Mathf.Lerp (deslocX, 0, Time.deltaTime);
		//deslocY = Mathf.Lerp (deslocY, 0, Time.deltaTime);
		aguloH = Mathf.Lerp (aguloH, 0, Time.deltaTime*5);
		aguloV = Mathf.Lerp (aguloV, 0, Time.deltaTime*5);
	}
}
