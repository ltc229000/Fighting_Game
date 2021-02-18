using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider2 : MonoBehaviour
{

    public GameObject thisObject;
    public GameObject otherObject;

    // Use this for initialization
    void Start () {
		
	}
    
    void sendMessage()
    {
        thisObject.SendMessage("defenceDetect");
    }

    public void OnTriggerStay2D(Collider2D otherCol)
    {
        if (thisObject.GetComponent<Player2>().attacking == true & otherCol.gameObject.layer == 8)
        {
            thisObject.GetComponent<Player2>().attacking = false;
            Invoke("sendMessage", 1);
        }

        if (thisObject.GetComponent<Player2>().kicking == true & otherCol.gameObject.layer == 8)
        {
            thisObject.GetComponent<Player2>().kicking = false;
            otherObject.GetComponent<Player1>().loseStamina = true;
            otherObject.SendMessage("getKicked");
        }
    }

    // Update is called once per frame
    void Update () {
        thisObject = GameObject.Find("P2(Clone)");
        otherObject = GameObject.Find("P1(Clone)");
        transform.position = thisObject.transform.position;
    }
}
