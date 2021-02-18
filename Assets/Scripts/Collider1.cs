using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider1 : MonoBehaviour
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
        if (thisObject.GetComponent<Player1>().attacking == true & otherCol.gameObject.layer == 9)
        {
            thisObject.GetComponent<Player1>().attacking = false;
            Invoke("sendMessage", 1);
        }

        if (thisObject.GetComponent<Player1>().kicking == true & otherCol.gameObject.layer == 9)
        {
            thisObject.GetComponent<Player1>().kicking = false;
            otherObject.GetComponent<Player2>().loseStamina = true;
            otherObject.SendMessage("getKicked");
        }
    }

    // Update is called once per frame
    void Update () {
        thisObject = GameObject.Find("P1(Clone)");
        otherObject = GameObject.Find("P2(Clone)");
        transform.position = thisObject.transform.position;
    }
}
