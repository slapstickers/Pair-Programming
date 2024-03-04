using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CratePickups : MonoBehaviour
{
    public int crateValue;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            ScoreManager.instance.AddPoints(crateValue);
            CameraController.instance.ChangeDirection();
        }
    }
}
