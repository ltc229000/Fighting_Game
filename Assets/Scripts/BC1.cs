using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BC1 : MonoBehaviour
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
        otherButton = GameObject.Find("BS1");
        if (otherButton.GetComponent<BS1>().active == true)
        {
            active = false;
        }
    }

    public void Click ()
    {
        active = true;
    }
}
