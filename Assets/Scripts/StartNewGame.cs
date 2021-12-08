using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartNewGame : MonoBehaviour 
{
    public InputField inputField;

    public void GetPlayerName()
    {
        MenuManager.instance.playerName = inputField.text;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

}
