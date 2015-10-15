using UnityEngine;
using System.Collections;

public class WeaponControl : MonoBehaviour {
    public GameObject MissilPrefab;
    public Gerenciador ger;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject insta= (GameObject) Instantiate(MissilPrefab,transform.position, transform.rotation);
            ger.AddProjectile(insta);
        }
	}
}
