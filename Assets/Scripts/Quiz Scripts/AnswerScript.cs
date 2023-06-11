using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{
    public bool isCorrect = false;
    public QuizManager quizManager;

    private Button theButton;
 
    private ColorBlock theColor;

    void Awake () {
        theButton = GetComponent<Button>();
        theColor = GetComponent<Button>().colors;
 
    }

    public void Answer()
    {
        if(isCorrect)
        {   
            theColor.pressedColor = Color.green;
 
            theButton.colors = theColor;
            Debug.Log("Correct Answer");
            quizManager.correct();
        }
        else
        {
            theColor.pressedColor = Color.red;
 
            theButton.colors = theColor;
            Debug.Log("Wrong Answer");
            quizManager.wrong();
        }
    }
}

