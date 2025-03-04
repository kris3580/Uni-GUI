using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    [SerializeField] private ScoreKeeper scoreKeeper;



    public void ShowFinalScore()
    {
        finalScoreText.text = $"Congratulations!\nYou got a score of {scoreKeeper.CalculateScore()}%";
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
