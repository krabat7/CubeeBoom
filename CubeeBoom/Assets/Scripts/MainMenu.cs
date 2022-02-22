using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject optionsMenu;
    [SerializeField] GameObject mainMenu;
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Options()
    {
        optionsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
