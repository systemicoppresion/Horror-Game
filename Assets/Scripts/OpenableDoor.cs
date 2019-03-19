using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenableDoor : MonoBehaviour
{

    public float smooth = 2.0f; 
    public float doorOpenAngle = 90.0f; 

    bool open = false;
    bool enter = false;

    float defaultRotationAngle;

    void Start()
    {
        defaultRotationAngle = transform.localEulerAngles.y;
    }

    
    void Update()
    {
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, Mathf.LerpAngle(transform.localEulerAngles.y, (open ? doorOpenAngle : defaultRotationAngle), Time.deltaTime * smooth), transform.localEulerAngles.z);

        if (Input.GetKeyDown(KeyCode.E) && enter)
        {
            open = !open;
        }
    }

    void OnGUI()
    {
        if (enter)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 100, 150, 30), "Press 'E' to open the door");
        }
    }

    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enter = true;
        }
    }

    
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enter = false;
        }
    }
}