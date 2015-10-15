using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {
    public GameObject poeira;
    ParticleSystem poeirapart;
    Quaternion normalposition;
	// Use this for initialization
	void Start () {
        poeirapart = poeira.GetComponent<ParticleSystem>();
        normalposition = new Quaternion();
	}
	float ang=0;
	float angraw=0;
    float angv = 0;
	// Update is called once per frame
	void Update () {
		angraw=Input.GetAxis("Horizontal");
        angv = Input.GetAxis("Vertical");
		ang+=angraw;
        transform.position += transform.forward * Time.deltaTime * 80;
        float alt = Terrain.activeTerrain.SampleHeight(transform.position);
        poeira.transform.position = new Vector3(transform.position.x, alt, transform.position.z);
        poeirapart.emissionRate = Mathf.Clamp(( 100 - (transform.position.y-alt)*3),0,100);
       
       // movimentosuperficie();
        movimento3d();
        colisaoterreno();
	}
    void colisaoterreno()
    {
        if ((transform.position.y - 1) < Terrain.activeTerrain.SampleHeight(transform.position))
        {
            transform.forward = Vector3.Reflect(transform.forward, Vector3.up);
            transform.position += Vector3.up;
        }
    }
    void movimento3d()
    {
      normalposition = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
      transform.Rotate( angv * Time.deltaTime * 100, angraw * Time.deltaTime * 00, -angraw * Time.deltaTime * 100);
      transform.Rotate(0, angraw * Time.deltaTime * 50, 0, Space.World);
      transform.rotation = Quaternion.Lerp(transform.rotation, normalposition, Time.deltaTime*2);
    }
    
    void movimentosuperficie()
    {
        float alt = Terrain.activeTerrain.SampleHeight(transform.position);
        transform.position = new Vector3(transform.position.x, alt + 5, transform.position.z);
        transform.rotation = Quaternion.Euler(new Vector3(0, ang, -angraw * 20));

    }
}
