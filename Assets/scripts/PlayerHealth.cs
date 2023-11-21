using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    
    public float Health;
    public float Maxhealth;
   
    public HealthBar healthbar;

    private void Start()
    {
        Health = Maxhealth;
        healthbar.InicializeHealth(Health);
    }
  

    public void GetDamage(float damage)
    {
        Health -= damage;
        healthbar.ChangeHealth(Health);

        if (Health <= 0)
        {
            Time.timeScale = 0f;
        }
    }

    public float GetHealth()
    {
        return Health;
    }

}
