using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float health = 20f;
    PlayerHealth damage;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }

    void Die()
        {
            Destroy(gameObject);
        }

    }

    private void OnTriggerEnter(GameObject other)
    {
        if (gameObject.tag == "Player")
        {
            SceneManager.LoadScene(2);
        }
    }
}
