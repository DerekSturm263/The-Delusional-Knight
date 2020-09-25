using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

public class UIManager : MonoBehaviour
{
    public static string objective = "Get inside the castle.";
    public TMPro.TMP_Text objectiveText;

    private EventSystem eventSystem;

    public GameObject pauseUI;
    private Animator pauseUIAnimator;

    public GameObject inventoryUI;
    private Animator inventoryUIAnimator;

    public Button[] pauseButtons;
    public GameObject[] optionsActions;

    public GameObject objectiveGO;
    public GameObject pauseButtonsLayout;
    public GameObject optionsLayout;

    public static bool isPaused;
    public static bool isInventoryOpen;

    public static bool isFullscreen = true;
    public static float musicVol = 1f;
    public static float soundVol = 1f;
    public static bool hasFancyGraphics = true;

    public GameObject lights2D;
    public GameObject lightGlobal;

    private void Awake()
    {
        eventSystem = EventSystem.current;
        isPaused = false;
        isInventoryOpen = false;

        if (pauseUI != null) pauseUIAnimator = pauseUI.GetComponent<Animator>();
        if (inventoryUI != null) inventoryUIAnimator = inventoryUI.GetComponent<Animator>();

        MusicPlayer.Initialize();
        SoundPlayer.Initialize();

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Main"))
        {
            Camera.main.GetComponent<Volume>().enabled = (hasFancyGraphics) ? true : false;
            lights2D.SetActive((hasFancyGraphics) ? true : false);
            lightGlobal.SetActive((!hasFancyGraphics) ? true : false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused) Pause();
            else if (!optionsLayout.activeSelf) Resume();
            else Back();
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (!isInventoryOpen) OpenInventory();
            else CloseInventory();
        }

        if (isInventoryOpen && (Input.GetAxisRaw("Horizontal") != 0f || Input.GetAxisRaw("Vertical") != 0f))
        {
            CloseInventory();
        }
    }

    public void Pause()
    {
        if (pauseUI.activeSelf || CutsceneManager.isInCutscene || DialogueManager.isDialoguing || isInventoryOpen)
            return;

        isPaused = true;
        pauseUI.SetActive(true);
        objectiveText.text = "Current Objective:\n" + objective;
        eventSystem.SetSelectedGameObject(pauseButtons[0].gameObject);
    }

    public void Resume()
    {
        pauseUIAnimator.SetBool("Exit", true);
        isPaused = false;
    }

    public void Options()
    {
        if (objectiveGO != null) objectiveGO.SetActive(false);
        pauseButtonsLayout.SetActive(false);
        optionsLayout.SetActive(true);
        eventSystem.SetSelectedGameObject(optionsActions[0]);
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
        if (objectiveGO != null) objectiveGO.SetActive(true);
        pauseButtonsLayout.SetActive(true);
        optionsLayout.SetActive(false);
        eventSystem.SetSelectedGameObject(pauseButtons[1].gameObject);
    }

    public void OnStart()
    {
        SceneManager.LoadScene("Main");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void OpenInventory()
    {
        if (inventoryUI.activeSelf || CutsceneManager.isInCutscene || DialogueManager.isDialoguing || isPaused)
            return;

        isInventoryOpen = true;
        inventoryUI.SetActive(true);
    }

    public void CloseInventory()
    {
        inventoryUIAnimator.SetBool("Exit", true);
        isInventoryOpen = false;
    }

    public void ToggleFullscreen()
    {
        isFullscreen = !isFullscreen;
        Screen.fullScreen = isFullscreen;
    }

    public void ChangeMusicVolume()
    {
        musicVol = optionsActions[1].GetComponent<Slider>().value;
        MusicPlayer.ChangeVolume(musicVol);
    }

    public void ChangeSFXVolume()
    {
        soundVol = optionsActions[2].GetComponent<Slider>().value;
        SoundPlayer.ChangeVolume(soundVol);
    }

    public void ToggleFancyGraphics()
    {
        hasFancyGraphics = !hasFancyGraphics;

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Main"))
        {
            Camera.main.GetComponent<Volume>().enabled = (hasFancyGraphics) ? true : false;
            lights2D.SetActive((hasFancyGraphics) ? true : false);
            lightGlobal.SetActive((!hasFancyGraphics) ? true : false);
        }
    }
}
