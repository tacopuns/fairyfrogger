using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public GameObject StartPanel;
    public GameObject ControlsPanel;

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

    public void OpenPanel()
    {
        if(StartPanel != null)
        {
            StartPanel.SetActive(true);
            ControlsPanel.SetActive(false);
        }

    }

    public void ControlsButton()
    {
        StartPanel.SetActive(false);
        ControlsPanel.SetActive(true);
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Main");
        Debug.Log("it work");
    }


}


