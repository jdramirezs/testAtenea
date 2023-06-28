using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject pauseMenu;
    public AudioSource audioJuego;
    // Start is called before the first frame update
    public void pausa()
    {
        Debug.Log("pausa");
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    public void resume()
    {
        Debug.Log("resume");
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void sonido(bool flag)
    {
        Debug.Log("sonido");
        if (flag)
        {
            audioJuego.Play();
        }
        else
        {
            audioJuego.Pause();
        }
        
    }


}
