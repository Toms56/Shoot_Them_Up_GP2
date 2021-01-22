using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "EnnemyBullet")
        {
            bulletSpeed = 5f;
            transform.Translate(Vector3.down * bulletSpeed * Time.deltaTime);
        }
        else if(gameObject.tag == "HeroBullet")
        {
            bulletSpeed = 8f;
            transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "HeroBullet" || other.gameObject.tag == "EnemyBullet")
        {
            Destroy(gameObject);
        }
    }
}
