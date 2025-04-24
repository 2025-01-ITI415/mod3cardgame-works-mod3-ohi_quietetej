using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene"); // Replace with your game scene name
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit(); // Only works in build
    }
}

