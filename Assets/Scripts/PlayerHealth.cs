using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;                            // The amount of health the player starts the game with.
    public int currentHealth;                                   // The current health the player has.                            
    public float flashSpeed = 5f;                               // The speed the damageImage will fade at.
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     // The colour the damageImage is set to, to flash.



    PlayerMovement playerMovement;                              // Reference to the player's movement.

    void Awake()
    {
        // Setting up the references.
        playerMovement = GetComponent<PlayerMovement>();

        // Set the initial health of the player.
        currentHealth = startingHealth;
    }


    void Update()
    {
     
    }


    public void HurtPlayer(int Damage, Vector3 direction)
    { 
            currentHealth -= Damage;   
    }


}
