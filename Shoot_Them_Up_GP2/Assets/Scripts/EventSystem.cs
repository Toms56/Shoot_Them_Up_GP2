using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventSystem : MonoBehaviour
{
    public Text ScoreTxt;
    public float Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Score <= 0)
        {
            Score = 0;
        }
        ScoreTxt.text = "Score: " + Score;
    }
}
