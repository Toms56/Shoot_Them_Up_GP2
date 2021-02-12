using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlayManager : MonoBehaviour
{
    public static GamePlayManager Instance;
    public Text scoreText;
    public float score;
    // Start is called before the first frame update
    private void Awake()
    {
        if( !Instance )
        {
            Instance = this;
        }
        else if(Instance)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + score;
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
