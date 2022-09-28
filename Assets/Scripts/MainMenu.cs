using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*******************************************/
/***** Funcions per carregar les escenes ***/
/***** un cop estem al final de la partida */
/*******************************************/
public class MainMenu : MonoBehaviour
{
    public GameObject PauseScreen;

    //Carrega l'escena principal 
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    //carrega l'escena del joc
    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
            PauseScreen.SetActive(!PauseScreen.activeSelf);
    }

}
