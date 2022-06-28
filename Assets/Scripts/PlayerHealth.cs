using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public Image healthBar;
    public float healthAmount = 100;
    public Behaviour mainCanvas;
    public Behaviour gameOverCanvas;
    public GameObject enemyPrefab;


    private void Update()
    {
        if (healthAmount <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            TakeDamage(100);
        }
    }

    public void TakeDamage(float Damage)
    {
        healthAmount -= Damage;
    }
}