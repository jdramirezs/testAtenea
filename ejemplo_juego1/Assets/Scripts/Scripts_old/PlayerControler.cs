using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{

    private bool canJump;
    private bool izquierda;
    private bool derecha;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(0, 1f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.position = new Vector3(gameObject.transform.position.x+2f*Time.deltaTime, gameObject.transform.position.y, 0);
        if ((Input.GetKey("right") || derecha == true ) && gameObject.transform.position.x < 8.35)
        {
            gameObject.transform.Translate(3.5f * Time.deltaTime, 0, 0);
        }
        else if ((Input.GetKey("left") || izquierda == true) && gameObject.transform.position.x >= -8.40)
        {
            gameObject.transform.Translate(-3.5f * Time.deltaTime, 0, 0);
        }

        ManageJump();

    }


    void ManageJump()
    {
        if (gameObject.transform.position.y <= -2.086f)
        {
            canJump = true;
        }

        if (Input.GetKey("up") && canJump && gameObject.transform.position.y < 1)
        {
            gameObject.transform.Translate(0, 3.5f * Time.deltaTime, 0);
        }
        else
        {
            canJump = false;
            if (gameObject.transform.position.y > -2.086f)
            {
                gameObject.transform.Translate(0, -3.5f * Time.deltaTime, 0);
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            //canForce = true;
            Debug.Log("GROUND COLLISION - canForce: " );
        }
    }

    public void izq() 
    {
        izquierda = true;
    }

    public void der()
    {
        derecha = true;
    }


    public void sinFuncion()
    {
        izquierda = false;
        derecha = false;
    }
}
