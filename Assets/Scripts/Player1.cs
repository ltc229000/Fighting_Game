using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player1 : MonoBehaviour
{

    public GameObject otherObject;
    public GameObject healthBar;
    public GameObject staminaBar;
    public GameObject gameOver;
    public Animator anim;
    public float health = 100;
    public float stamina = 100;
    public float speed = 0;
    public float x = 1;
    public bool canMove = true;
    public bool moving = false;
    public bool attacking = false;
    public bool defending = false;
    public bool kicking = false;
    public bool shield = false;
    public bool loseStamina = false;
    public bool doing = false;
    public bool right = true;
    public bool up = true;
    public bool test = true;
    public bool sword = false;
    public bool chopper = false;
    public bool otherDefence;
    public bool otherRight;
    public bool otherUp;
    

	// Use this for initialization
	void Start ()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Activate ()
    {
        canMove = true;
        attacking = false;
        defending = false;
        kicking = false;
        doing = false;
    }

    void kickSuccess()
    {
        kicking = true;
    }

    void getDamaged ()
    {
        canMove = true;
        defending = false;
        shield = false;
        doing = false;

        if (otherObject.GetComponent<Player2>().sword == true)
        {
            health -= 20;
            stamina -= 20;
        }

        else if (otherObject.GetComponent<Player2>().chopper == true)
        {
            health -= 25;
            stamina -= 15;
        }

        if (otherObject.transform.position.x > gameObject.transform.position.x & sword == true)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector3(-10, 0, 0), ForceMode2D.Impulse);
            anim.SetBool("Sword up idle right", false);
            anim.SetBool("Sword up idle left", false);
            anim.SetBool("Sword up walk right", false);
            anim.SetBool("Sword up walk left", false);
            anim.SetBool("Sword up attack right", false);
            anim.SetBool("Sword up attack left", false);
            anim.SetBool("Sword up parry right", false);
            anim.SetBool("Sword up parry left", false);
            anim.SetBool("Sword down idle right", false);
            anim.SetBool("Sword down idle left", false);
            anim.SetBool("Sword down walk right", false);
            anim.SetBool("Sword down walk left", false);
            anim.SetBool("Sword down attack right", false);
            anim.SetBool("Sword down attack left", false);
            anim.SetBool("Sword down parry right", false);
            anim.SetBool("Sword down parry left", false);
            anim.SetBool("Sword hurt right", true);
            anim.SetBool("Sword hurt left", false);
            anim.SetBool("Sword kick right", false);
            anim.SetBool("Sword kick left", false);

        }

        else if (otherObject.transform.position.x < gameObject.transform.position.x & sword == true)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector3(10, 0, 0), ForceMode2D.Impulse);
            anim.SetBool("Sword up idle right", false);
            anim.SetBool("Sword up idle left", false);
            anim.SetBool("Sword up walk right", false);
            anim.SetBool("Sword up walk left", false);
            anim.SetBool("Sword up attack right", false);
            anim.SetBool("Sword up attack left", false);
            anim.SetBool("Sword up parry right", false);
            anim.SetBool("Sword up parry left", false);
            anim.SetBool("Sword down idle right", false);
            anim.SetBool("Sword down idle left", false);
            anim.SetBool("Sword down walk right", false);
            anim.SetBool("Sword down walk left", false);
            anim.SetBool("Sword down attack right", false);
            anim.SetBool("Sword down attack left", false);
            anim.SetBool("Sword down parry right", false);
            anim.SetBool("Sword down parry left", false);
            anim.SetBool("Sword hurt right", false);
            anim.SetBool("Sword hurt left", true);
            anim.SetBool("Sword kick right", false);
            anim.SetBool("Sword kick left", false);

        }

        else if (otherObject.transform.position.x > gameObject.transform.position.x & chopper == true)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector3(-10, 0, 0), ForceMode2D.Impulse);
            anim.SetBool("Chopper up idle right", false);
            anim.SetBool("Chopper up idle left", false);
            anim.SetBool("Chopper up walk right", false);
            anim.SetBool("Chopper up walk left", false);
            anim.SetBool("Chopper up attack right", false);
            anim.SetBool("Chopper up attack left", false);
            anim.SetBool("Chopper up parry right", false);
            anim.SetBool("Chopper up parry left", false);
            anim.SetBool("Chopper down idle right", false);
            anim.SetBool("Chopper down idle left", false);
            anim.SetBool("Chopper down walk right", false);
            anim.SetBool("Chopper down walk left", false);
            anim.SetBool("Chopper down attack right", false);
            anim.SetBool("Chopper down attack left", false);
            anim.SetBool("Chopper down parry right", false);
            anim.SetBool("Chopper down parry left", false);
            anim.SetBool("Chopper hurt right", true);
            anim.SetBool("Chopper hurt left", false);
            anim.SetBool("Chopper kick right", false);
            anim.SetBool("Chopper kick left", false);

        }

        else if (otherObject.transform.position.x < gameObject.transform.position.x & chopper == true)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector3(10, 0, 0), ForceMode2D.Impulse);
            anim.SetBool("Chopper up idle right", false);
            anim.SetBool("Chopper up idle left", false);
            anim.SetBool("Chopper up walk right", false);
            anim.SetBool("Chopper up walk left", false);
            anim.SetBool("Chopper up attack right", false);
            anim.SetBool("Chopper up attack left", false);
            anim.SetBool("Chopper up parry right", false);
            anim.SetBool("Chopper up parry left", false);
            anim.SetBool("Chopper down idle right", false);
            anim.SetBool("Chopper down idle left", false);
            anim.SetBool("Chopper down walk right", false);
            anim.SetBool("Chopper down walk left", false);
            anim.SetBool("Chopper down attack right", false);
            anim.SetBool("Chopper down attack left", false);
            anim.SetBool("Chopper down parry right", false);
            anim.SetBool("Chopper down parry left", false);
            anim.SetBool("Chopper hurt right", false);
            anim.SetBool("Chopper hurt left", true);
            anim.SetBool("Chopper kick right", false);
            anim.SetBool("Chopper kick left", false);

        }
    }

    void decreaseStamina()
    {
        stamina -= 40;
        loseStamina = false;
        Invoke("Activate", 1);
    }

    void block()
    {
        if (shield == true)
        {
            stamina -= 25;
        }
        else
        {
            stamina -= 10;
        }
    }

    void getKicked()
    {
        canMove = false;

        if (otherRight == false & otherObject.transform.position.x > gameObject.transform.position.x)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector3(-30, 0, 0), ForceMode2D.Impulse);
            if (loseStamina == true)
            {
                decreaseStamina();
            }                
        }

        if (otherRight == true & otherObject.transform.position.x < gameObject.transform.position.x)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector3(30, 0, 0), ForceMode2D.Impulse);
            if (loseStamina == true)
            {
                decreaseStamina();
            }
        }
    }

    void defenceDetect ()
    {
        if (right == true & up == true & otherDefence == true & otherRight == false & otherUp == true & otherObject.transform.position.x > gameObject.transform.position.x
            || right == true & up == false & otherDefence == true & otherRight == false & otherUp == false & otherObject.transform.position.x > gameObject.transform.position.x
            || right == false & up == true & otherDefence == true & otherRight == true & otherUp == true & otherObject.transform.position.x < gameObject.transform.position.x
            || right == false & up == false & otherDefence == true & otherRight == true & otherUp == false & otherObject.transform.position.x < gameObject.transform.position.x)
        {
            Debug.Log("Parry Success!");
            otherObject.SendMessage("block");
        }

        else
        {
            otherObject.SendMessage("getDamaged");
        }
    }

    // Update is called once per frame

    void Update ()
    {
        otherObject = GameObject.Find("P2(Clone)");
        healthBar = GameObject.Find("HealthBar1");
        staminaBar = GameObject.Find("StaminaBar1");
        gameOver = GameObject.Find("GameOver");
        otherDefence = otherObject.GetComponent<Player2>().defending;
        otherRight = otherObject.GetComponent<Player2>().right;
        otherUp = otherObject.GetComponent<Player2>().up;

        healthBar.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(3 * health, 20);
        staminaBar.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(3 * stamina, 10);

        if (health < 100)
        {
            health = health + 3 * Time.deltaTime;
        }

        if (health <= 0)
        {
            gameOver.SendMessage("gameover");
            Destroy(this.gameObject);
        }

        if (stamina < 100)
        {
            stamina = stamina + 7 * Time.deltaTime;
        }

        if (stamina <= 20)
        {
            canMove = false;
            test = false;
        }

        else if (canMove == false & test == false & stamina > 20)
        {
            canMove = true;
            test = true;
        }

        if (speed >= x * 0.5f)
        {
            speed = x * 0.5f;
        }

        if (sword == true)
        {
            if (canMove == true & Input.GetKeyDown(KeyCode.W))
            {
                up = true;
            }

            if (canMove == true & Input.GetKeyDown(KeyCode.S))
            {
                up = false;
            }

            if (canMove == true & up == true & right == true)
            {
                if (doing == false & Input.GetKeyDown(KeyCode.J))
                {
                    stamina -= 25;
                    canMove = false;
                    moving = true;
                    attacking = true;
                    doing = true;
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", true);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", false);
                    Invoke("Activate", 1.5f);
                }
                else if (doing == false & Input.GetKeyDown(KeyCode.K))
                {
                    stamina -= 10;
                    canMove = false;
                    moving = true;
                    defending = true;
                    doing = true;
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", true);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", false);
                    Invoke("Activate", 1);
                }
                else if (doing == false & Input.GetKeyDown(KeyCode.L))
                {
                    stamina -= 15;
                    canMove = false;
                    moving = true;
                    doing = true;
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", true);
                    anim.SetBool("Sword kick left", false);
                    Invoke("Activate", 1.7f);
                    Invoke("kickSuccess", 0.7f);
                }
                else if (doing == false & Input.GetKey(KeyCode.D) & !Input.GetKey(KeyCode.A))
                {
                    moving = true;
                    right = true;
                    speed = speed + Time.deltaTime;
                    transform.Translate(speed * 15 * Time.deltaTime, 0, 0, Space.World);
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", true);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", false);
                }
                else if (doing == false & Input.GetKey(KeyCode.A) & !Input.GetKey(KeyCode.D))
                {
                    moving = true;
                    right = false;
                    speed = speed + Time.deltaTime;
                    transform.Translate(speed * 15 * -Time.deltaTime, 0, 0, Space.World);
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", true);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", false);
                }
                else
                {
                    moving = false;
                    speed = 0;
                    anim.SetBool("Sword up idle right", true);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", false);
                }
            }

            if (canMove == true & up == false & right == true)
            {
                if (doing == false & Input.GetKeyDown(KeyCode.J))
                {
                    stamina -= 25;
                    canMove = false;
                    moving = true;
                    attacking = true;
                    doing = true;
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", true);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", false);
                    Invoke("Activate", 1.5f);
                }
                else if (doing == false & Input.GetKeyDown(KeyCode.K))
                {
                    stamina -= 10;
                    canMove = false;
                    moving = true;
                    defending = true;
                    doing = true;
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", true);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", false);
                    Invoke("Activate", 1);
                }
                else if (doing == false & Input.GetKeyDown(KeyCode.L))
                {
                    stamina -= 15;
                    canMove = false;
                    moving = true;
                    doing = true;
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", true);
                    anim.SetBool("Sword kick left", false);
                    Invoke("Activate", 1.7f);
                    Invoke("kickSuccess", 0.7f);
                }
                else if (doing == false & Input.GetKey(KeyCode.D) & !Input.GetKey(KeyCode.A))
                {
                    moving = true;
                    right = true;
                    speed = speed + Time.deltaTime;
                    transform.Translate(speed * 15 * Time.deltaTime, 0, 0, Space.World);
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", true);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", false);
                }
                else if (doing == false & Input.GetKey(KeyCode.A) & !Input.GetKey(KeyCode.D))
                {
                    moving = true;
                    right = false;
                    speed = speed + Time.deltaTime;
                    transform.Translate(speed * 15 * -Time.deltaTime, 0, 0, Space.World);
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", true);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", false);
                }
                else
                {
                    moving = false;
                    speed = 0;
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", true);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", false);
                }
            }

            if (canMove == true & up == true & right == false)
            {
                if (doing == false & Input.GetKeyDown(KeyCode.J))
                {
                    stamina -= 25;
                    canMove = false;
                    moving = true;
                    attacking = true;
                    doing = true;
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", true);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", false);
                    Invoke("Activate", 1.5f);
                }
                else if (doing == false & Input.GetKeyDown(KeyCode.K))
                {
                    stamina -= 10;
                    canMove = false;
                    moving = true;
                    defending = true;
                    doing = true;
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", true);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", false);
                    Invoke("Activate", 1);
                }
                else if (doing == false & Input.GetKeyDown(KeyCode.L))
                {
                    stamina -= 15;
                    canMove = false;
                    moving = true;
                    doing = true;
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", true);
                    Invoke("Activate", 1.7f);
                    Invoke("kickSuccess", 0.7f);
                }
                else if (doing == false & Input.GetKey(KeyCode.D) & !Input.GetKey(KeyCode.A))
                {
                    moving = true;
                    right = true;
                    speed = speed + Time.deltaTime;
                    transform.Translate(speed * 15 * Time.deltaTime, 0, 0, Space.World);
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", true);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", false);
                }
                else if (doing == false & Input.GetKey(KeyCode.A) & !Input.GetKey(KeyCode.D))
                {
                    moving = true;
                    right = false;
                    speed = speed + Time.deltaTime;
                    transform.Translate(speed * 15 * -Time.deltaTime, 0, 0, Space.World);
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", true);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", false);
                }
                else
                {
                    moving = false;
                    speed = 0;
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", true);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", false);
                }
            }

            if (canMove == true & up == false & right == false)
            {
                if (doing == false & Input.GetKeyDown(KeyCode.J))
                {
                    stamina -= 25;
                    canMove = false;
                    moving = true;
                    attacking = true;
                    doing = true;
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", true);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", false);
                    Invoke("Activate", 1.5f);
                }
                else if (doing == false & Input.GetKeyDown(KeyCode.K))
                {
                    stamina -= 10;
                    canMove = false;
                    moving = true;
                    defending = true;
                    doing = true;
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", true);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", false);
                    Invoke("Activate", 1);
                }
                else if (doing == false & Input.GetKeyDown(KeyCode.L))
                {
                    stamina -= 15;
                    canMove = false;
                    moving = true;
                    doing = true;
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", true);
                    Invoke("Activate", 1.7f);
                    Invoke("kickSuccess", 0.7f);
                }
                else if (doing == false & Input.GetKey(KeyCode.D) & !Input.GetKey(KeyCode.A))
                {
                    moving = true;
                    right = true;
                    speed = speed + Time.deltaTime;
                    transform.Translate(speed * 15 * Time.deltaTime, 0, 0, Space.World);
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", true);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", false);
                }
                else if (doing == false & Input.GetKey(KeyCode.A) & !Input.GetKey(KeyCode.D))
                {
                    moving = true;
                    right = false;
                    speed = speed + Time.deltaTime;
                    transform.Translate(speed * 15 * -Time.deltaTime, 0, 0, Space.World);
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", false);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", true);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", false);
                }
                else
                {
                    moving = false;
                    speed = 0;
                    anim.SetBool("Sword up idle right", false);
                    anim.SetBool("Sword up idle left", false);
                    anim.SetBool("Sword up walk right", false);
                    anim.SetBool("Sword up walk left", false);
                    anim.SetBool("Sword up attack right", false);
                    anim.SetBool("Sword up attack left", false);
                    anim.SetBool("Sword up parry right", false);
                    anim.SetBool("Sword up parry left", false);
                    anim.SetBool("Sword down idle right", false);
                    anim.SetBool("Sword down idle left", true);
                    anim.SetBool("Sword down walk right", false);
                    anim.SetBool("Sword down walk left", false);
                    anim.SetBool("Sword down attack right", false);
                    anim.SetBool("Sword down attack left", false);
                    anim.SetBool("Sword down parry right", false);
                    anim.SetBool("Sword down parry left", false);
                    anim.SetBool("Sword hurt right", false);
                    anim.SetBool("Sword hurt left", false);
                    anim.SetBool("Sword kick right", false);
                    anim.SetBool("Sword kick left", false);
                }
            }
        }

        else if (chopper == true)
        {
            anim.SetBool("Sword up idle right", false);

            if (doing == false & Input.GetKeyDown(KeyCode.I))
            {
                stamina -= 25;
                shield = true;
            }

            if (doing == true & Input.GetKeyDown(KeyCode.I))
            {
                canMove = true;
                defending = false;
                shield = false;
                doing = false;
            }

            if (right == true & shield == true)
            {
                canMove = false;
                moving = true;
                defending = true;
                doing = true;
                anim.SetBool("Chopper up idle right", false);
                anim.SetBool("Chopper up idle left", false);
                anim.SetBool("Chopper up walk right", false);
                anim.SetBool("Chopper up walk left", false);
                anim.SetBool("Chopper up attack right", false);
                anim.SetBool("Chopper up attack left", false);
                anim.SetBool("Chopper up parry right", false);
                anim.SetBool("Chopper up parry left", false);
                anim.SetBool("Chopper down idle right", false);
                anim.SetBool("Chopper down idle left", false);
                anim.SetBool("Chopper down walk right", false);
                anim.SetBool("Chopper down walk left", false);
                anim.SetBool("Chopper down attack right", false);
                anim.SetBool("Chopper down attack left", false);
                anim.SetBool("Chopper down parry right", false);
                anim.SetBool("Chopper down parry left", false);
                anim.SetBool("Chopper hurt right", false);
                anim.SetBool("Chopper hurt left", false);
                anim.SetBool("Chopper kick right", false);
                anim.SetBool("Chopper kick left", false);
                anim.SetBool("Chopper shield right", true);
                anim.SetBool("Chopper shield left", false);
            }

            if (right == false & shield == true)
            {
                canMove = false;
                moving = true;
                defending = true;
                doing = true;
                anim.SetBool("Chopper up idle right", false);
                anim.SetBool("Chopper up idle left", false);
                anim.SetBool("Chopper up walk right", false);
                anim.SetBool("Chopper up walk left", false);
                anim.SetBool("Chopper up attack right", false);
                anim.SetBool("Chopper up attack left", false);
                anim.SetBool("Chopper up parry right", false);
                anim.SetBool("Chopper up parry left", false);
                anim.SetBool("Chopper down idle right", false);
                anim.SetBool("Chopper down idle left", false);
                anim.SetBool("Chopper down walk right", false);
                anim.SetBool("Chopper down walk left", false);
                anim.SetBool("Chopper down attack right", false);
                anim.SetBool("Chopper down attack left", false);
                anim.SetBool("Chopper down parry right", false);
                anim.SetBool("Chopper down parry left", false);
                anim.SetBool("Chopper hurt right", false);
                anim.SetBool("Chopper hurt left", false);
                anim.SetBool("Chopper kick right", false);
                anim.SetBool("Chopper kick left", false);
                anim.SetBool("Chopper shield right", false);
                anim.SetBool("Chopper shield left", true);
            }

            if (canMove == true & Input.GetKeyDown(KeyCode.W))
            {
                up = true;
            }

            if (canMove == true & Input.GetKeyDown(KeyCode.S))
            {
                up = false;
            }

            if (canMove == true & up == true & right == true)
            {
                if (doing == false & Input.GetKeyDown(KeyCode.J))
                {
                    stamina -= 30;
                    canMove = false;
                    moving = true;
                    attacking = true;
                    doing = true;
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", true);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                    Invoke("Activate", 1.5f);
                }
                else if (doing == false & Input.GetKeyDown(KeyCode.K))
                {
                    stamina -= 10;
                    canMove = false;
                    moving = true;
                    defending = true;
                    doing = true;
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", true);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                    Invoke("Activate", 1);
                }
                else if (doing == false & Input.GetKeyDown(KeyCode.L))
                {
                    stamina -= 15;
                    canMove = false;
                    moving = true;
                    doing = true;
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", true);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                    Invoke("Activate", 1.7f);
                    Invoke("kickSuccess", 0.7f);
                }
                else if (doing == false & Input.GetKey(KeyCode.D) & !Input.GetKey(KeyCode.A) & !Input.GetKeyDown(KeyCode.I))
                {
                    moving = true;
                    right = true;
                    speed = speed + Time.deltaTime;
                    transform.Translate(speed * 15 * Time.deltaTime, 0, 0, Space.World);
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", true);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                }
                else if (doing == false & Input.GetKey(KeyCode.A) & !Input.GetKey(KeyCode.D) & !Input.GetKeyDown(KeyCode.I))
                {
                    moving = true;
                    right = false;
                    speed = speed + Time.deltaTime;
                    transform.Translate(speed * 15 * -Time.deltaTime, 0, 0, Space.World);
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", true);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                }
                else
                {
                    moving = false;
                    speed = 0;
                    anim.SetBool("Chopper up idle right", true);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                }
            }

            if (canMove == true & up == false & right == true)
            {
                if (doing == false & Input.GetKeyDown(KeyCode.J))
                {
                    stamina -= 30;
                    canMove = false;
                    moving = true;
                    attacking = true;
                    doing = true;
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", true);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                    Invoke("Activate", 1.5f);
                }
                else if (doing == false & Input.GetKeyDown(KeyCode.K))
                {
                    stamina -= 10;
                    canMove = false;
                    moving = true;
                    defending = true;
                    doing = true;
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", true);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                    Invoke("Activate", 1);
                }
                else if (doing == false & Input.GetKeyDown(KeyCode.L))
                {
                    stamina -= 15;
                    canMove = false;
                    moving = true;
                    doing = true;
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", true);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                    Invoke("Activate", 1.7f);
                    Invoke("kickSuccess", 0.7f);
                }
                else if (doing == false & Input.GetKey(KeyCode.D) & !Input.GetKey(KeyCode.A) & !Input.GetKeyDown(KeyCode.I))
                {
                    moving = true;
                    right = true;
                    speed = speed + Time.deltaTime;
                    transform.Translate(speed * 15 * Time.deltaTime, 0, 0, Space.World);
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", true);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                }
                else if (doing == false & Input.GetKey(KeyCode.A) & !Input.GetKey(KeyCode.D) & !Input.GetKeyDown(KeyCode.I))
                {
                    moving = true;
                    right = false;
                    speed = speed + Time.deltaTime;
                    transform.Translate(speed * 15 * -Time.deltaTime, 0, 0, Space.World);
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", true);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                }
                else
                {
                    moving = false;
                    speed = 0;
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", true);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                }
            }

            if (canMove == true & up == true & right == false)
            {
                if (doing == false & Input.GetKeyDown(KeyCode.J))
                {
                    stamina -= 30;
                    canMove = false;
                    moving = true;
                    attacking = true;
                    doing = true;
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", true);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                    Invoke("Activate", 1.5f);
                }
                else if (doing == false & Input.GetKeyDown(KeyCode.K))
                {
                    stamina -= 10;
                    canMove = false;
                    moving = true;
                    defending = true;
                    doing = true;
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", true);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                    Invoke("Activate", 1);
                }
                else if (doing == false & Input.GetKeyDown(KeyCode.L))
                {
                    stamina -= 15;
                    canMove = false;
                    moving = true;
                    doing = true;
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", true);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                    Invoke("Activate", 1.7f);
                    Invoke("kickSuccess", 0.7f);
                }
                else if (doing == false & Input.GetKey(KeyCode.D) & !Input.GetKey(KeyCode.A) & !Input.GetKeyDown(KeyCode.I))
                {
                    moving = true;
                    right = true;
                    speed = speed + Time.deltaTime;
                    transform.Translate(speed * 15 * Time.deltaTime, 0, 0, Space.World);
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", true);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                }
                else if (doing == false & Input.GetKey(KeyCode.A) & !Input.GetKey(KeyCode.D) & !Input.GetKeyDown(KeyCode.I))
                {
                    moving = true;
                    right = false;
                    speed = speed + Time.deltaTime;
                    transform.Translate(speed * 15 * -Time.deltaTime, 0, 0, Space.World);
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", true);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                }
                else
                {
                    moving = false;
                    speed = 0;
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", true);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                }
            }

            if (canMove == true & up == false & right == false)
            {
                if (doing == false & Input.GetKeyDown(KeyCode.J))
                {
                    stamina -= 30;
                    canMove = false;
                    moving = true;
                    attacking = true;
                    doing = true;
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", true);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                    Invoke("Activate", 1.5f);
                }
                else if (doing == false & Input.GetKeyDown(KeyCode.K))
                {
                    stamina -= 10;
                    canMove = false;
                    moving = true;
                    defending = true;
                    doing = true;
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", true);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                    Invoke("Activate", 1);
                }
                else if (doing == false & Input.GetKeyDown(KeyCode.L))
                {
                    stamina -= 15;
                    canMove = false;
                    moving = true;
                    doing = true;
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", true);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                    Invoke("Activate", 1.7f);
                    Invoke("kickSuccess", 0.7f);
                }
                else if (doing == false & Input.GetKey(KeyCode.D) & !Input.GetKey(KeyCode.A) & !Input.GetKeyDown(KeyCode.I))
                {
                    moving = true;
                    right = true;
                    speed = speed + Time.deltaTime;
                    transform.Translate(speed * 15 * Time.deltaTime, 0, 0, Space.World);
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", true);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                }
                else if (doing == false & Input.GetKey(KeyCode.A) & !Input.GetKey(KeyCode.D) & !Input.GetKeyDown(KeyCode.I))
                {
                    moving = true;
                    right = false;
                    speed = speed + Time.deltaTime;
                    transform.Translate(speed * 15 * -Time.deltaTime, 0, 0, Space.World);
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", false);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", true);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                }
                else
                {
                    moving = false;
                    speed = 0;
                    anim.SetBool("Chopper up idle right", false);
                    anim.SetBool("Chopper up idle left", false);
                    anim.SetBool("Chopper up walk right", false);
                    anim.SetBool("Chopper up walk left", false);
                    anim.SetBool("Chopper up attack right", false);
                    anim.SetBool("Chopper up attack left", false);
                    anim.SetBool("Chopper up parry right", false);
                    anim.SetBool("Chopper up parry left", false);
                    anim.SetBool("Chopper down idle right", false);
                    anim.SetBool("Chopper down idle left", true);
                    anim.SetBool("Chopper down walk right", false);
                    anim.SetBool("Chopper down walk left", false);
                    anim.SetBool("Chopper down attack right", false);
                    anim.SetBool("Chopper down attack left", false);
                    anim.SetBool("Chopper down parry right", false);
                    anim.SetBool("Chopper down parry left", false);
                    anim.SetBool("Chopper hurt right", false);
                    anim.SetBool("Chopper hurt left", false);
                    anim.SetBool("Chopper kick right", false);
                    anim.SetBool("Chopper kick left", false);
                    anim.SetBool("Chopper shield right", false);
                    anim.SetBool("Chopper shield left", false);
                }
            }
        }
    }
}