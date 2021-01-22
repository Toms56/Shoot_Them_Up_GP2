using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlayManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
     public void onClick_Retry()
        {
            //SceneManager.UnloadSceneAsync(1);
            SceneManager.LoadScene("Level1");
        }
    
        public void onClick_Menu()
        {
            //SceneManager.UnloadSceneAsync(1);
            SceneManager.LoadScene("MainMenu"); 
        }
    
        public void exitGame()
        {
            Application.Quit();
            Debug.Log("Game is exiting");
        }
}
