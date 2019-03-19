using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gizmo : MonoBehaviour {

    public float gizmoSize = .75f;

	// Use this for initialization
	void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, gizmoSize);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
