using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;
    public bool followPlayer;
    public float scrollSpeed;
    public float scrollDirection;
    public Transform player;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        followPlayer = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (followPlayer)
        {
            transform.position = player.transform.position + new Vector3(0, 1, -5);
        }
        else
        {
            transform.Translate((scrollDirection * scrollSpeed), 0, 0);
        }

    }

    public void ChangeDirection()
    {
        scrollDirection = scrollDirection * -1;
    }
}
