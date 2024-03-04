using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;

    public float scrollSpeed;
    public float scrollDirection;
    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((scrollDirection * scrollSpeed), 0, 0);
    }

    public void ChangeDirection()
    {
        scrollDirection = scrollDirection * -1;
    }
}
