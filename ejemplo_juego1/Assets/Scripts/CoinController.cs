using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinController : MonoBehaviour
{
    public AudioSource audioSource;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Moneda");

        gameObject.SetActive(false);
        //Destroy(gameObject);

        if (SceneManager.GetActiveScene().name == "Nivel_1") {
            Debug.Log("Audio Play");
            playAudio();
            //SceneManager.LoadScene("Nivel_2");
        }
        else {
            playAudio();
            SceneManager.LoadScene("Nivel_2");
        }

    }

    void playAudio()
    {
        audioSource.Play();
    }
}
