using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lamb : MonoBehaviour
{
    public int maxHealth = 10000;
    public int currentHealth;

    public HealthBar healthBar;


    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        currentHealth -= 1;
        healthBar.SetHealth(currentHealth);
    
    }
}
