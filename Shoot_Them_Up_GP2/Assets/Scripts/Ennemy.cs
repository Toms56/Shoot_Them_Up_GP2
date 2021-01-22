using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    [SerializeField]
    float speed = 5f;
    public GameObject[] munition;
    private bool moveLeft = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 2)
        {
            if (!moveLeft)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
        }
        else
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        if(transform.position.x <= -4)
        {
            moveLeft = false;
        }
        else if(transform.position.x >= 4)
        {
            moveLeft = true;
        }
        


    }
}
