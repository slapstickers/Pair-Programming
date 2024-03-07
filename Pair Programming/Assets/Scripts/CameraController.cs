using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController instance;
    public AudioSource musicPlayer;
    public bool followPlayer;
    public float scrollSpeed;
    public float scrollDirection;
    public AudioClip fastSong;
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
        if (followPlayer == true)
        {
            transform.position = player.transform.position + new Vector3(0, 2, -5);
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
    public void ChangeMusic()
    {
        musicPlayer.Stop();
        musicPlayer.clip = fastSong;
        musicPlayer.Play();
    }
}
