using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish_GameOver : MonoBehaviour
{

    public SceneFader fader;
    public int NextLevel;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "FallDetector")
        {
            PlayerPrefs.SetString("previousLevel", SceneManager.GetActiveScene().name);
            fader.FadeTo("GameOver");
        }
        if (other.tag == "Finish")
        {
            PlayerPrefs.SetInt("levelReached", NextLevel);
            fader.FadeTo("MainMenu");

        }
    }
}
