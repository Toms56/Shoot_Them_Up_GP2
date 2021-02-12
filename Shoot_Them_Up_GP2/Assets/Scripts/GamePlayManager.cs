using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlayManager : MonoBehaviour
{
<<<<<<< HEAD

    [SerializeField]
    private bool pause = false;

    public GameObject panePause;
=======
    public static GamePlayManager Instance;
    public Text scoreText;
    public float score;
>>>>>>> c2b2f62c5e1d5e4957495873dc5b015139da14ec
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
<<<<<<< HEAD
        if (pause == false)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }

        if (Input.GetKey(KeyCode.P))
        {
            if (pause == true)
            {
                pause = false;
                panePause.SetActive(false);
            }
            else
            {
                pause = true;
                panePause.SetActive(true);
            }
        }
=======
        scoreText.text = "Score : " + score;
>>>>>>> c2b2f62c5e1d5e4957495873dc5b015139da14ec
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
