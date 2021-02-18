using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public GameObject MainMenu;
    public GameObject GameOverText;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void restart()
    {
        MainMenu.SetActive(true);
        GameOverText.SetActive(false);
        SceneManager.LoadScene("SampleScene");
    }

    void gameover()
    {
        GameOverText.SetActive(true);
        GameObject.Find("Bar").SetActive(false);
        Invoke("restart", 3);
    }
}
