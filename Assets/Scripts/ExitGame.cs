using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*******************************************/
/****** Script per sortir del joc **********/
/*******************************************/
public class ExitGame : MonoBehaviour
{
    // Funcio que escriu per debug el text i tanca l'aplicació 
    public void Exit()
    {
        Debug.Log("Marxant del joc");
        Application.Quit();
    }

}
