using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    private bool isMute;

    public void OnClick_StartGame()
    {
        SceneManager.LoadScene(2);
    }
    
    public void OnClick_Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void GameOver()
    {
        SceneManager.LoadScene(1);
    }

    /*public void OnClick_CommandeMenu()
    {
        SceneManager.LoadScene();
    }*/
    
    public void onClick_muteSound()
    {
        isMute = !isMute;
        AudioListener.volume =  isMute ? 0 : 1;
        Debug.Log("Muted " + AudioListener.volume);
    }
    
    public void exitGame()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
