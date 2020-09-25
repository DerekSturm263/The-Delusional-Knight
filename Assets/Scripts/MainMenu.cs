using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject settingsMenu;

    public void PlayGame()
    {
        SceneManager.LoadScene("Main");
        Debug.Log("Start Game");
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void NextCredit()
    {
        SceneManager.LoadScene("Credits");
        Debug.Log("Credits");
    
    
    }

    public void OpenSettings()
    {

    }
}
