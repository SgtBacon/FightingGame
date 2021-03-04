using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    //on press, select the level being pressed
    public void LevelSelect(Button b)
    {
        SceneManager.LoadScene(b.name);
        Debug.Log(b.name);
    }

    //on press, return to character select screen
    public void ReturnToCharacters()
    {
        SceneManager.LoadScene("PlayerSelect");
    }
}
