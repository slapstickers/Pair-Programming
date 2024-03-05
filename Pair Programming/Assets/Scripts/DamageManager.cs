using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageManager : MonoBehaviour
{
    [SerializeField] private int enemyDamage;
    [SerializeField] private HealthManager healthManager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Damage();
        }
    }

    void Damage()
    {
        healthManager.playerHealth = healthManager.playerHealth - enemyDamage;
        healthManager.UpdateHealth();
        gameObject.SetActive(false);
    }
}
