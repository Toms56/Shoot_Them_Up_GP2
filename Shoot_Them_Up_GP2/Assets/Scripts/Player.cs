using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject shoot;

    public Camera mainCamera;

    public Vector3 screenBounds, mousePointer;

    private float fireRate = 0.3f, speed = 0.1f, time, objectWitdh, objectHeight;
    private Vector3 shootOffSet = new Vector3(0, 0.3f, 0);
    // Start is called before the first frame update
    void Start()
    {

        objectWitdh = transform.GetComponent<SpriteRenderer>().bounds.extents.x; //give the player width
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y; //give the player height
        screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z)); //screen to world point convert 2d pos to 3d pos
    }

    // Update is called once per frame
    void Update()
    {
        mousePointer = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        if (transform.position != mousePointer)
        {
            transform.position = Vector3.Lerp(transform.position, mousePointer - new Vector3(0, 0, mousePointer.z), Time.deltaTime * speed * 8f);

        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (Time.time > time)
            {
                Instantiate(shoot, transform.position + shootOffSet, transform.rotation);
                time = Time.time + fireRate;
            }
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(1);
        }
    }

    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, -screenBounds.x + objectWitdh + mainCamera.transform.position.x * 2, screenBounds.x - objectWitdh); //clamp(value,min,max)
        viewPos.y = Mathf.Clamp(viewPos.y, -screenBounds.y + objectHeight + mainCamera.transform.position.y * 2, screenBounds.y - objectHeight);
        transform.position = viewPos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag != "HeroBullet")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.TryGetComponent<Ennemy>(out Ennemy ennemy))
        {
            GamePlayManager.Instance.score -= 10;
            GamePlayManager.nbr -= 1;
        }
    }
}
