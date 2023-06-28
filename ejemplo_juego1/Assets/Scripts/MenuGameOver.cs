using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
    public GameObject GameOverMenu;
    public void continuar()
    {
        Debug.Log("pausa");
        GameOverMenu.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Nivel_1");
    }

    public void salir()
    {
        GameOverMenu.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuInicio");
    }
}
