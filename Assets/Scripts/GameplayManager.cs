using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/****************************************/
/***** Classe amb la logica del joc *****/
/****************************************/
public class GameplayManager : MonoBehaviour
{
    //Variables publiques per enllaçar elements del joc
    public Text HistoryText;
    public Transform AnswersParent;
    public GameObject ButtonAnswerPrefab;
    //variable privada per guardar el node actual. 
    private StoryNode currentNode;

    //Funcio que s'executa en el primer fotograma del joc
    private void Start()
    {
        //Carrega a memoria la historia amb estructura de nodes
        currentNode = StoryFiller.FillStory();
        // Deixa el textbox buit
        HistoryText.text = string.Empty;
        //Crida a la funcio per construir els botons inicials
        FillUi();
    }

    // funcio que escriu la historia i crea els botons per poder elegir la següent acciò
    void FillUi()
    {
        HistoryText.text += "\n"+currentNode.History;

        foreach (Transform child in AnswersParent.transform)
        {
            Destroy(child.gameObject);
        }

        var isLeft = true;
        var height = 100.0f;
        var index = 0;
        //per cada opcio de respota creem el boto
        foreach (var answer in currentNode.Answers)
        {
            //Creem una nova instancia del boto prefams
            var buttonAnswerCopy = Instantiate(ButtonAnswerPrefab, AnswersParent, true);
            //Calculem la nova posició 
            var x = buttonAnswerCopy.GetComponent<RectTransform>().rect.x * 1.05f;
            buttonAnswerCopy.GetComponent<RectTransform>().localPosition = new Vector3(isLeft ? x : -x, height, 0);

            if (!isLeft)
            {
                height += buttonAnswerCopy.GetComponent<RectTransform>().rect.y * 2.0f;
            }
            isLeft = !isLeft;
            //associem a cada boto l'index del node respota. 
            FillListener(buttonAnswerCopy.GetComponent<Button>(), index);

            buttonAnswerCopy.GetComponentInChildren<Text>().text = answer;

            index++;
        }
    }

    // Funcio que enllaç l'even onClick del boto actual amb el node resposta
    private void FillListener(Button button, int index)
    {
        button.onClick.AddListener(() => { AnswerSelected(index); });
    }

    //funcio que afegeix el text de respota al textbox del dialeg comprova si hem arribat al final 
    private void AnswerSelected(int index)
    {
        HistoryText.text += "\n" + currentNode.Answers[index];

        if (!currentNode.IsFinal)
        {
            //carrega el node respota com actual 
            currentNode = currentNode.NextNode[index];

            currentNode.OnNodeVisited?.Invoke();
            //crida a la funcio perquè creii les noves possibilitats
            FillUi();
        }
        else
        {
            //Carrega l'escena per reiniciar el joc o tornar al menu principal
            SceneManager.LoadScene("FiJoc");

        }
    }
    //comprava a cada frame del joc si volem sortir i tornar al menu principal mitjançant la tecla ESC
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
            SceneManager.LoadScene("MainMenu");
    }
}
