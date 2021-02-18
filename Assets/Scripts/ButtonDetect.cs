using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDetect : MonoBehaviour {

    public GameObject BS1;
    public GameObject BC1;
    public GameObject BS2;
    public GameObject BC2;
    public GameObject p1;
    public GameObject collider1;
    public GameObject p2;
    public GameObject collider2;
    public GameObject p3;
    public GameObject collider3;
    public GameObject p4;
    public GameObject collider4;
    public GameObject Bar;
    Vector3 a = new Vector3(-10, 0, 0);
    Vector3 b = new Vector3(10, 0, 0);
    Quaternion c = new Quaternion(0, 0, 0, 0);

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        BS1 = GameObject.Find("BS1");
        BC1 = GameObject.Find("BC1");
        BS2 = GameObject.Find("BS2");
        BC2 = GameObject.Find("BC2");

        if (BS1.GetComponent<BS1>().active == true & BS2.GetComponent<BS2>().active == true)
        {
            GameObject.Find("SelectMenu").SetActive(false);
            p1 = GameObject.Instantiate(p1, a, c);
            collider1 = GameObject.Instantiate(collider1, a, c);
            p3 = GameObject.Instantiate(p3, b, c);
            collider3 = GameObject.Instantiate(collider3, b, c);
            p1.GetComponent<Player1>().sword = true;
            p3.GetComponent<Player2>().sword = true;
            Bar.SetActive(true);
        }

        else if (BS1.GetComponent<BS1>().active == true & BC2.GetComponent<BC2>().active == true)
        {
            GameObject.Find("SelectMenu").SetActive(false);
            p1 = GameObject.Instantiate(p1, a, c);
            collider1 = GameObject.Instantiate(collider1, a, c);
            p4 = GameObject.Instantiate(p4, b, c);
            collider4 = GameObject.Instantiate(collider4, b, c);
            p1.GetComponent<Player1>().sword = true;
            p4.GetComponent<Player2>().chopper = true;
            Bar.SetActive(true);
        }

        else if (BC1.GetComponent<BC1>().active == true & BS2.GetComponent<BS2>().active == true)
        {
            GameObject.Find("SelectMenu").SetActive(false);
            p2 = GameObject.Instantiate(p2, a, c);
            collider2 = GameObject.Instantiate(collider2, a, c);
            p3 = GameObject.Instantiate(p3, b, c);
            collider3 = GameObject.Instantiate(collider3, b, c);
            p2.GetComponent<Player1>().chopper = true;
            p3.GetComponent<Player2>().sword = true;
            Bar.SetActive(true);
        }

        else if (BC1.GetComponent<BC1>().active == true & BC2.GetComponent<BC2>().active == true)
        {
            GameObject.Find("SelectMenu").SetActive(false);
            p2 = GameObject.Instantiate(p2, a, c);
            collider2 = GameObject.Instantiate(collider2, a, c);
            p4 = GameObject.Instantiate(p4, b, c);
            collider4 = GameObject.Instantiate(collider4, b, c);
            p2.GetComponent<Player1>().chopper = true;
            p4.GetComponent<Player2>().chopper = true;
            Bar.SetActive(true);
        }
    }
}
