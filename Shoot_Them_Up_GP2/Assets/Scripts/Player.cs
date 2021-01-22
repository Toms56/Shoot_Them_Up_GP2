using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject shoot;

    public Camera mainCamera;

    public Vector3 screenBounds;

    private float fireRate = 0.2f, speed = 5f, time, objectWitdh, objectHeight;
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
        if (Input.GetKey("z"))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        if (Input.GetKey("q"))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (Time.time > time)
            {
                Instantiate(shoot, transform.position + shootOffSet, transform.rotation);
                time = Time.time + fireRate;
            }
        }
    }

    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, -screenBounds.x + objectWitdh + mainCamera.transform.position.x * 2, screenBounds.x - objectWitdh); //clamp(value,min,max)
        viewPos.y = Mathf.Clamp(viewPos.y, -screenBounds.y + objectHeight + mainCamera.transform.position.y * 2, screenBounds.y - objectHeight);
        transform.position = viewPos;
    }
}
