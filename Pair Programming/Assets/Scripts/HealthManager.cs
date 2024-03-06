using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int playerHealth;

    [SerializeField] private Image[] hearts;

    private void Start()
    {
        UpdateHealth();
    }

    public void UpdateHealth()
    {
        if (playerHealth <= 0)
        {
            SceneManager.LoadScene("DiedLol");
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < playerHealth)                                       
            {
                hearts[i].color = Color.red;
            }
            else
            {
                hearts[i].color = Color.black;
            }

        }
    }
}
