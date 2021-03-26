using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Ennemy;
    private bool moveLeft = false;
    private float speed = 3f, delay = 1f, time;
    // Start is called before the first frame update
    void Start()
    {
        time = Time.time;
        //InvokeRepeating("SpawnEnnemy", 0f, 2f);
    }
    // Update is called once per frame
    void Update()
    {
        if(GamePlayManager.nbr < 6)
        {
            if(Time.time > time)
            {
                SpawnEnnemy();
                time = Time.time + delay;
            }
        }
        if (!moveLeft)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (transform.position.x <= -4)
        {
            moveLeft = false;
        }
        else if (transform.position.x >= 4)
        {
            moveLeft = true;
        }
    }
    void SpawnEnnemy()
    {
        Instantiate(Ennemy[Random.Range(0, Ennemy.Length)], transform.position, transform.rotation);
        GamePlayManager.nbr += 1;
    }
}
