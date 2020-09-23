using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text questionText = null;
    [SerializeField] private Question question = null;
    [SerializeField] private AnswerButton[] answerButtons;       

    private void Start()
    {
        Debug.Log("GameManager Start");
        // Setting question text with question string
        questionText.text = question.question;

        // Setting answers
        // Array are zero based, the first value starts at index 0
        // For loop
        for (int i = 0; i < question.answers.Length; i++)
        {
            answerButtons[i].SetAnswer(question.answers[i]);
        }
    }
}