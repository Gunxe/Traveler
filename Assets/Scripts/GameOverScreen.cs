using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;

    public SceneFader fader;

    public void Seutup(int Score)
    {
        gameObject.SetActive(true);
        pointsText.text = Score.ToString() + " POINTS";
    }

    public void Start()
    {

    }

    public void RestartButton()
    {
       // SceneManager.Load("Game");
    }

    public void ExitButton()
    {
        fader.FadeTo("MainMenu");   
    }
}
