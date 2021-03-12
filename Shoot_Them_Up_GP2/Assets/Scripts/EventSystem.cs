using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventSystem : MonoBehaviour
{
    public Text ScoreTxt, CommandTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GamePlayManager.Instance.score <= 0)
        {
            GamePlayManager.Instance.score = 0;
        }
        ScoreTxt.text = "Score: " + GamePlayManager.Instance.score;
        CommandTxt.text = " les commandes sont : la souris, barre espace et échap";
    }
}
