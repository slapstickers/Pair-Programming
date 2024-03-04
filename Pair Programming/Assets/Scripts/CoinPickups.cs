using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickups : MonoBehaviour
{
    public int coinValue;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            ScoreManager.instance.AddPoints(coinValue);
        }
    }
}
