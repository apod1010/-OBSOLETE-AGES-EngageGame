using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour 
{
    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;

        Animator animator;
    //playermovement
    //playershooting

    bool isDead;
    bool damaged;


    private void Awake()
    {

        currentHealth = startingHealth;
    }

    private void Update()
    {
        
    }

    public void TakeDamage (int amount)
    {
        damaged = true;

        currentHealth -= amount;

        healthSlider.value = currentHealth;

        if(currentHealth <= 0 && !isDead)
        {
            Death();
        }
    }

    public void Death()
    {
        isDead = true;
        Debug.Log("DEAD!");
    }


}
