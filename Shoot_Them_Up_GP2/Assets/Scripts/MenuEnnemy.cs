using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuEnnemy : MonoBehaviour
{
    float speed = 5f;
    bool moveLeft;
    SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!moveLeft)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (transform.position.x <= -15)
        {
            moveLeft = false;
            sprite.flipX = false;
        }
        else if (transform.position.x >= 15)
        {
            moveLeft = true;
            sprite.flipX = true;
        }
    }
}
