using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text scoreText;
    int score = 0;

    public void GameOver()
    {
        Invoke("EndGame", 0.35f);
    }

    private void EndGame()
    {
        Time.timeScale = 0;
    }
}
