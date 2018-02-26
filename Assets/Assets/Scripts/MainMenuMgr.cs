using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuMgr : MonoBehaviour 
{
    public void StartButtonClick()
    {
        SceneManager.LoadScene("main");
    }

    public void CreditsButtonClick()
    {
        SceneManager.LoadScene("credits");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
