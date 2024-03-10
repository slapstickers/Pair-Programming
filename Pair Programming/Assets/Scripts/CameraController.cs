using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //public static CameraController instance;
    public bool followPlayer;
    public float scrollSpeed;
    public float scrollDirection;
    public Transform player;
    public AudioSource audioSource;
    public AudioClip fastSong;

    /*
    private void Awake()
    {
        instance = this;
    }
    */
    private void Start()
    {
        followPlayer = true;
        audioSource = GetComponent<AudioSource>();
    }

    void LateUpdate()
    {
        if (followPlayer)
        {
            transform.position = player.transform.position + new Vector3(0, 1, -5);
        }
        else
        {
            transform.Translate((scrollDirection * scrollSpeed * Time.deltaTime), 0, 0);
        }
    }

    public void ChangeDirection()
    {
        scrollDirection = -scrollDirection;
        audioSource.Stop();
        audioSource.clip = fastSong;
        audioSource.Play();
    }
}
