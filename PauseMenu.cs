using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public PlayerController player;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
                    
            }
            else
            {
                Pause();
                    
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        player.enabled = true;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        player.enabled = false;
    }
    public void LevelSelection()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
