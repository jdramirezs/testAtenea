using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    bool canForce;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(0, 6.1f, 0);
        Debug.Log("INIT");
        Debug.Log("GRAVITY: " + Physics2D.gravity[1] + " [m/s²]");
        Debug.Log("DELTA TIME: " + Time.deltaTime + " [s]");
        Debug.Log("FREQUENCY: " + 1 / Time.deltaTime + " [fps]");
        Debug.Log(Physics2D.simulationMode);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right") && gameObject.transform.position.x < 8.35)
        {
            gameObject.transform.Translate(3.5f * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("left") && canForce && gameObject.transform.position.x >= -8.40)
        {
            //gameObject.transform.Translate(-3.5f*Time.deltaTime, 0, 0);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1000f, 0)); // Fuerza en Newtons
            Debug.Log("LEFT - canForce: " + canForce);
        }

        if (Input.GetKeyDown("up") && canForce)
        {
            Debug.Log("UP - canForce: " + canForce);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -50 * Physics2D.gravity[1] * gameObject.GetComponent<Rigidbody2D>().mass));
            canForce = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            canForce = true;
            Debug.Log("GROUND COLLISION - canForce: " + canForce);
        }
    }


    //Physics2D.simulationMode = SimulationMode2D.FixedUpdate;
}

