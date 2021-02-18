using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BC2 : MonoBehaviour
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
        otherButton = GameObject.Find("BS2");
        if (otherButton.GetComponent<BS2>().active == true)
        {
            active = false;
        }
	}

    public void Click ()
    {
        active = true;
    }
}
