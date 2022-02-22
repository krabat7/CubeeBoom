using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject gameMenu;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        gameMenu.SetActive(false);
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        gameMenu.SetActive(true);
    }

    public void FirstMenu()
    {
        SceneManager.LoadScene(0);
    }
    void OnDisable()
    {
        Time.timeScale = 1;
    }

    void OnEnable()
    {
        Time.timeScale = 0;
    }

}
