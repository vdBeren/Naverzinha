using UnityEngine;
using System.Collections;

public class IAEnemy : MonoBehaviour {
    public GameObject Player;
    public GameObject Torre;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       
        Vector3 vecmov = Torre.transform.position - transform.position;
        transform.forward = vecmov;
        transform.position += vecmov.normalized * Time.deltaTime*10;

	}
}
