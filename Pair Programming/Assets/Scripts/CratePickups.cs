using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CratePickups : MonoBehaviour
{
    public int crateValue;
    public CameraController cameraController;
    public GameObject barrier;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            ScoreManager.instance.AddPoints(crateValue);
            cameraController.followPlayer = false;
            CameraController.instance.ChangeDirection();
            Destroy(barrier);
            CameraController.instance.ChangeMusic();
        }
    }
}
