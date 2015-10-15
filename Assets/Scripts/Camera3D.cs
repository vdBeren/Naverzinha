using UnityEngine;
using System.Collections;

public class Camera3D : MonoBehaviour {
	public Transform jogador;
	public float distanciadanave=10;
    public float alturadanave = 3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		OlhaPara(jogador.position);
        VaiPara(jogador.position);
	}
	void VaiPara(Vector3 para){
        Vector3 vtn = (para - jogador.forward * distanciadanave)  +Vector3.up * alturadanave;
        transform.position = Vector3.Lerp(transform.position, vtn, Time.smoothDeltaTime * 5);
	}
    void VaiParaVetorial(Vector3 para)
    {
        Vector3 vtn = (para - jogador.forward * distanciadanave) + Vector3.up * alturadanave;
        Vector3 vecmov = vtn - transform.position;
        transform.position+=vecmov*0.1f;
    }
	void OlhaPara(Vector3 para){/* codigo br para lookat */
		Vector3 vpn=para-transform.position;
		transform.forward=vpn;
	}
}
