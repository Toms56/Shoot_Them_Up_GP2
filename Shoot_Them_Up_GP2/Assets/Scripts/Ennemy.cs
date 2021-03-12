using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    [SerializeField]
    float speed = 5f;
    public GameObject[] munition;
    private bool moveLeft = false;
    Vector3 offset = new Vector3(0, -2, 0);
    float repeatRate;
    // Start is called before the first frame update
    private void Awake()
    {
        if(gameObject.tag == "Ennemy")
        {
            repeatRate = 1f;
        }
        else if (gameObject.tag == "Ennemy2")
        {
            repeatRate = 1.5f;
        }
        else
        {
            repeatRate = 2f;
        }
    }
    void Start()
    {
        InvokeRepeating("EnnemyShoot", 3f, repeatRate);
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
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent<BulletScript>(out BulletScript bulletScript))
        {
            GamePlayManager.nbr -= 1;
            GamePlayManager.Instance.score += 50;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
    void EnnemyShoot()
    {
        Instantiate(munition[0], transform.position + offset ,Quaternion.identity);
    }
}
