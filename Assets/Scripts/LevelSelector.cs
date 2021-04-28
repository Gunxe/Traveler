using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelSelector : MonoBehaviour
{
    public SceneFader fader;
    public Button[] levelButton;


    public void Select (string levelName)
    {
        fader.FadeTo(levelName);
    }


    // Start is called before the first frame update
    void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);
        for (int i = 0; i < levelButton.Length; i++)
        {
            if(i + 1 > levelReached)
            {
                levelButton[i].interactable = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
