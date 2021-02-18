using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{

    public GameObject SelectMenu;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void Click ()
    {
        SelectMenu.SetActive(true);
        GameObject.Find("MainMenu").SetActive(false);
    }
}
