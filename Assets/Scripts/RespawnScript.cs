using UnityEngine;
using System.Collections;

public class RespawnScript : MonoBehaviour
{

    public GameObject spawnPoint;

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Enemy")
        {
            this.transform.position = spawnPoint.transform.position;
        }
    }
}