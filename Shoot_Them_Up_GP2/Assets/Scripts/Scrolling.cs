using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    public float speedRatio = 1f;

    Renderer _bgRend;
    float _cameraWidth;
    float _scrollTime, scrollSpeed = 5f;

    private void Start()
    {
        _bgRend = GetComponent<Renderer>();

        Vector2 screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        _cameraWidth = screenBounds.x * 2f;
        _scrollTime = speedRatio * scrollSpeed / _cameraWidth;
    }

    private void Update()
    {
        _bgRend.material.mainTextureOffset += new Vector2( 0f, _scrollTime * Time.deltaTime);
    }
}
