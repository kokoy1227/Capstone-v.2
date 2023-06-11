using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<QuestionAnswer> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject QuizPanel;
    public GameObject GoPanel;
    public GameObject QuizCanvas;

    public Text QuestionTxt;
    public Text ScoreTxt;

    int TotalQuestions = 0;
    public int score;

    private void Start()
    {
        TotalQuestions = QnA.Count;
        GoPanel.SetActive(false);
        generateQuestion();
    }

    void QuizOver()
    {
        QuizPanel.SetActive(false);
        GoPanel.SetActive(true);
        ScoreTxt.text = score + "/" + TotalQuestions;
    }

    public void exit()
    {
        QuizCanvas.SetActive(false);
    }

    public void correct()
    {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i+1)
            {   
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }
        }
    }

    void generateQuestion()
    {
        if(QnA.Count > 0)
        {
            currentQuestion = Random.Range(0,QnA.Count);

            QuestionTxt.text = QnA[currentQuestion].Question;
            SetAnswers();
 
        }
        else
        {
            Debug.Log("Out of Question");
            QuizOver();
        }
        
    }
}
