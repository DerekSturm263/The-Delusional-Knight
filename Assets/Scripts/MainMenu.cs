using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Movement");
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
        SceneManager.LoadScene(2);
        Debug.Log("Credits");
            }
}
