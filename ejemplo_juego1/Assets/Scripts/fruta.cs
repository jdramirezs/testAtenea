using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fruta : MonoBehaviour
{
    public Puntaje puntaje;
    public float cantidadPuntos = 100f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Fruta");

        //gameObject.SetActive(false);
        puntaje.SumarPuntos(cantidadPuntos);
        Destroy(gameObject);      

    }
}

