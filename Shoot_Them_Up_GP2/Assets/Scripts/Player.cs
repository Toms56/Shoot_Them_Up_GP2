using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("z"))
        {
            transform.position = new Vector3(0,1 * Time.deltaTime * speed,0);
        }
        if (Input.GetKeyDown("s"))
        {
            transform.position = new Vector3(0, -1 * Time.deltaTime * speed, 0);
        }
    }
}
