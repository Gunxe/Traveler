using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selector : MonoBehaviour
{
    public SceneFader fader;
    public void restart()
    {
        fader.FadeTo(PlayerPrefs.GetString("previousLevel"));
    }

    public void mainMenu()
    {
        fader.FadeTo("MainMenu");
    }


}
