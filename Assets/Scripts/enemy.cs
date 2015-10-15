using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {
	public int vida=5;
	public GameObject  damageMark;
	public GameObject prefExlo;
	// Use this for initialization
	void Start () {
		damageMark.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
	
	}
	void DisableDamageMark () {
		damageMark.SetActive (false);
	}

	public void OnParticleCollision(GameObject other) {
		vida--;
		damageMark.SetActive (true);
		MainScript.Pontos++;
		Invoke ("DisableDamageMark", 0.5f);
		if (vida < 0) {
			MainScript.Pontos+=10;
			Instantiate(prefExlo,transform.position,transform.rotation);
			Destroy(gameObject.transform.parent.gameObject);
		}
		print (gameObject.name + " Atingido");
	}
}
