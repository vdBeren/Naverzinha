using UnityEngine;
using System.Collections;

public class Gerenciador : MonoBehaviour {
    public GameObject PrefabEnemy;
    public GameObject[] respawpoints;
    public GameObject Player;
    public GameObject Torre;
    public GameObject PrefabExplosion;
    public int Pontos;
    ArrayList enemylist;
    ArrayList projectilelist;
	// Use this for initialization
	void Start () {
        projectilelist = new ArrayList();
        enemylist = new ArrayList();
        InvokeRepeating("EnemyCreate", 0, 15);
	}
	
	// Update is called once per frame
	void Update () {
        foreach (IAEnemy ene in enemylist)
        {
            for (int i = 0; i < projectilelist.Count;i++ )
            {
                if (((GameObject)projectilelist[i]) != null)
                {
                    if (Vector3.Distance(ene.transform.position, ((GameObject)projectilelist[i])
                        .transform.position) < 50)
                    {
                        Destroy(ene.gameObject);
                        Destroy(((GameObject)projectilelist[i]).gameObject);
                        projectilelist.RemoveAt(i);
                        enemylist.Remove(ene);
                        Instantiate(PrefabExplosion, ene.transform.position, ene.transform.rotation);
                        Pontos += 10;
                        return;
                    }
                }
                else
                {
                    projectilelist.RemoveAt(i);
                    return;
                }
            }

        }
	    
	}

    void EnemyCreate()
    {
        int r=0;
        r = Random.Range(0, respawpoints.Length);
       GameObject enemyinstance=(GameObject) 
           Instantiate(PrefabEnemy, respawpoints[r].transform.position,
            respawpoints[r].transform.rotation);

       IAEnemy refIA = enemyinstance.GetComponent<IAEnemy>();
       refIA.Player = Player;
       refIA.Torre = Torre;
       enemylist.Add(refIA);
    }
    public void AddProjectile(GameObject proj)
    {
        projectilelist.Add(proj);

    }
}
