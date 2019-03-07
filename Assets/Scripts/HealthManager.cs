using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour {

    private bool isRespawning;
    private Vector3 respawnPoint;
    public float respawnlength;

    public PlayerMovement Player;



    public void Respawn()
    {
        //thePlayer.transform.position = respawnPoint;
        //currentHealth = maxHealth;
        if (!isRespawning)
        {
            StartCoroutine("RespawnCo");
        }
    }



    public IEnumerator RespawnCo()
    {
        isRespawning = true;
        Player.gameObject.SetActive(false);

        yield return new WaitForSeconds(respawnlength);


        Player.gameObject.SetActive(true);
        Player.transform.position = respawnPoint;
        var playerHealth = GetComponent<PlayerHealth>();

    }


    public void SetSpawnPoint(Vector3 newPosition)
    {
        respawnPoint = newPosition;
    }
}

