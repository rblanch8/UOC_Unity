using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*******************************************/
/****** Script per sortir del joc **********/
/*******************************************/
public class ExitGame : MonoBehaviour
{
    // Funcio que escriu per debug el text i tanca l'aplicaci� 
    public void Exit()
    {
        Debug.Log("Marxant del joc");
        Application.Quit();
    }

}
