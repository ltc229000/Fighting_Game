using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatalArea : MonoBehaviour {

    public GameObject gameOver;
    
    // Use this for initialization
    void Start () {
		
	}

    public void OnTriggerStay2D(Collider2D otherCol)
    {
        gameOver.SendMessage("gameover");
        Destroy(otherCol.gameObject);
    }

    // Update is called once per frame
    void Update () {
        gameOver = GameObject.Find("GameOver");


    }
}
