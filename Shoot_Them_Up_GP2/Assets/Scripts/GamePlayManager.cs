using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlayManager : MonoBehaviour
{

    [SerializeField]
    private bool pause = false;

    public GameObject panePause;
    public static GamePlayManager Instance;
    public Text scoreText;
    public float score;
    public static float nbr = 0;
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
        if (pause == false)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }

        if (Input.GetKeyDown(KeyCode.P))
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
        scoreText.text = "Score : " + score;
    }
    
     public void onClick_Retry()
        {
            //SceneManager.UnloadSceneAsync(1);
            SceneManager.LoadScene(2);
        }
    
        public void onClick_Menu()
        {
            //SceneManager.UnloadSceneAsync(1);
            SceneManager.LoadScene(0); 
        }
    
        public void exitGame()
        {
            Application.Quit();
            Debug.Log("Game is exiting");
        }
}
