using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class HUDControl : MonoBehaviour {
    public Text PointsDisplay;
    public Gerenciador Ger;
    public GameObject PausePanel;
    
	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
        PointsDisplay.text = Ger.Pontos.ToString();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PausePanel.SetActive(true);
            Time.timeScale = 0.000001f;
        }
	}
    public void UnPause()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;

    }
}
