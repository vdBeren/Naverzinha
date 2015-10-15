using UnityEngine;
using System.Collections;

public class MissilControl : MonoBehaviour {
 
	// Use this for initialization
	void Start () {
        Invoke("AutoDestroy", 5);
       
	}
  
	
	// Update is called once per frame
	void Update () {
       
            transform.position += transform.forward * Time.deltaTime * 200;
       
	}

    void AutoDestroy()
    {
        Destroy(gameObject);
    }
}
