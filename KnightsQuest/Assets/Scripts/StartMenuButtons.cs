using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenuButtons : MonoBehaviour
{

    public Button playButton;
    public Button quitButton;

    void Start()
    {
        playButton.onClick.AddListener(PlayButton);
        quitButton.onClick.AddListener(QuitButton);
    }

    public void PlayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitButton ()
    {
        Debug.Log("Iesi afara!");
        Application.Quit();
    }
}
