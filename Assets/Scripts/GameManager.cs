using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text questionText = null;
    [SerializeField] private Text[] answerText;

    [SerializeField] private Question question = null;
    [SerializeField] private Answer[] answer = null;

    private void Start()
    {
        // Setting question text with question string
        questionText.text = question.question;

        // Setting answer text
        answerText[0].text = answer[0].answer;
    }
}