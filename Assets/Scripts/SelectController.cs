﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectController : MonoBehaviour
{

    //Select character based on Button being clicked
    //might change later to individual functionality
    //current goal is to have button pressed and any button has the same code to select that character in it's name
    public void CharacterSelect(Button b)
    {
        //PlayerSelect.pickplayer
        Debug.Log(b.name);
        SceneManager.LoadScene("LevelSelect");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    //TODO add function to let player pick a character and then send that character into the new scene
}
