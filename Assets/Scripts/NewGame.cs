using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    // Funcio que carrega l'escena del joc i ho escriu pel debut
    public void StartNewGame()
    {
        Debug.Log("sceneName to load: Game");
        SceneManager.LoadScene("Game");
    }

}
