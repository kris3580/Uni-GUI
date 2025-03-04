using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Quiz quiz;
    private EndScreen endScreen;
    [SerializeField] GameObject quizCanvas;
    [SerializeField] GameObject endCanvas;

    private void Awake()
    {
        quiz = FindObjectOfType<Quiz>();
        endScreen = endCanvas.GetComponent<EndScreen>();
    }

    private void Update()
    {
        if (quiz.isComplete)
        {
            endScreen.ShowFinalScore();
            quizCanvas.SetActive(false);
            endCanvas.SetActive(true);
        }
    }
}
