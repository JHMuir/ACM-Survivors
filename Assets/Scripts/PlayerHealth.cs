using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health = 5;
    public int maxHealth = 5;

    float period = 0f;

    [SerializeField] GameObject gameOverCanvas;


    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            GameOver();
        }
    }

    public void GainHealth(int heal)
    {
        health += heal;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    private void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.tag == "Enemy")
        {
            if (period > .1f)
            {
                TakeDamage(1);
                period = 0;
            }
            period += UnityEngine.Time.deltaTime;
            
        }
    }

    void GameOver()
    {
        Debug.Log("Game Over");
        Time.timeScale = 0;
        gameOverCanvas.SetActive(true);
    }


    
}
