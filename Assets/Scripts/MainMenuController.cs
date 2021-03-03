using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    //On press, start game
    public void StartGame()
    {
        Debug.Log("Start");
        //SceneManager.LoadScene("PlayerSelect");
    }

    //On press, Quit Game
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    //On press, open Options
    public void Options()
    {
        Debug.Log("Options");
    }
}
