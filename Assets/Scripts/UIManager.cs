using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    private EventSystem eventSystem;

    public GameObject pauseUI;
    private Animator pauseUIAnimator;

    public Button[] pauseButtons;

    public TMPro.TMP_Text label;
    public GameObject pauseButtonsLayout;
    public GameObject optionsLayout;

    public static bool isPaused;

    private void Awake()
    {
        eventSystem = EventSystem.current;
        pauseUIAnimator = pauseUI.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused) Pause();
            else if (!optionsLayout.activeSelf) Resume();
            else Back();
        }
    }

    public void Pause()
    {
        if (pauseUI.activeSelf || CutsceneManager.isInCutscene || DialogueManager.isDialoguing)
            return;

        isPaused = true;
        pauseUI.SetActive(true);
        eventSystem.SetSelectedGameObject(pauseButtons[0].gameObject);
    }

    public void Resume()
    {
        pauseUIAnimator.SetBool("Exit", true);
        isPaused = false;
    }

    public void Options()
    {
        pauseButtonsLayout.SetActive(false);
        optionsLayout.SetActive(true);
        label.text = "Options";
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void Title()
    {
        SceneManager.LoadScene("StartTitle");
    }

    public void Back()
    {
        pauseButtonsLayout.SetActive(true);
        optionsLayout.SetActive(false);
        label.text = "Pause";
    }
}
