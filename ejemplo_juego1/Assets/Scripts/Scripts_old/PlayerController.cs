using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float velocidad;
    public float multiplicador;
    public Rigidbody2D rb;
    private float minMax = 50f;
    public float fuerzaSalto;
    private bool saltando;

    public bool isLeft = false;
    public bool isRigth = false;
    public bool isJump = false;
    public float jumpForce;
    public float speedForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            saltando = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isLeft)
        {
            rb.AddForce(new Vector2(-speedForce,0)*Time.deltaTime);
        }

        if (isRigth)
        {
            rb.AddForce(new Vector2(speedForce, 0) * Time.deltaTime);
        }

        if (isJump)
        {
            isJump = false;
            rb.AddForce(new Vector2(0,jumpForce));
        }

        float entradaTeclado = Input.GetAxis("Horizontal");
        rb.AddForce(Vector2.right * velocidad * multiplicador * entradaTeclado);
        float limitador = Mathf.Clamp(rb.velocity.x, -minMax, minMax);
        rb.velocity = new Vector2(limitador, rb.velocity.y);
        if (saltando)
        {
            rb.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
            saltando = false;
        }

    }

    public void clickLeft()
    {
        isLeft = true;
    }

    public void clickjump()
    {
        isJump = true;
    }

    public void clickRigth()
    {
        isRigth = true;
    }

    public void resetMov()
    {
        isLeft = false;
        isRigth = false;
        isJump = false;
    }
}
