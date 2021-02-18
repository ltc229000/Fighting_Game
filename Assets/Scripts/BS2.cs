using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BS2 : MonoBehaviour
{

    public GameObject otherButton;
    public bool active = false;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        otherButton = GameObject.Find("BC2");
        if (otherButton.GetComponent<BC2>().active == true)
        {
            active = false;
        }
    }

    public void Click ()
    {
        active = true;
    }
}
