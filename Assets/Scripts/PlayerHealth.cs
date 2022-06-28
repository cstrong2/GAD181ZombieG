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

    public GameObject score;
    private TextMesh scoreText;

    private void Start()
    {
        scoreText = score.GetComponent<TextMesh>();
        PlayerPrefs.SetString("currentScore", "0");
    }

    private void Update()
    {
        if (healthAmount <= 0)
        {
            SceneManager.LoadScene(2);
            PlayerPrefs.SetString("currentScore", scoreText.text);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        TakeDamage(100);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void TakeDamage(float Damage)
    {
        healthAmount -= Damage;
    }
}