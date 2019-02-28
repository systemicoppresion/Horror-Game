using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    // Use this for initialization
    void Start() {
    }
        public Transform Player;
    public float Attack_range;
    public float Chase_Range;
    public float Distance;
    public float RotSpeed = 3; // the target's rotation speed
    public float MoveSpeed = 1; // the target's moving speed
    void Update()
    {

        // The Distance Between Our Player and The Target(Enemy)
        Distance = (Player.transform.position - transform.position).magnitude;

        // when the target gets close to the player
        if (Distance <= Chase_Range && Distance > Attack_range)
        {
            GetComponent<Animator>().SetBool("Walking", true);
            Vector3 Direction = Player.position - transform.position; // the defference of position of these two objects, in order to use in rotation 
            Direction.y = 0; // so the target won't rotate in the y-axis

            // rotate the target toward the player
            transform.rotation = Quaternion.Slerp(transform.rotation,
                                                  Quaternion.LookRotation(Direction), RotSpeed * Time.deltaTime);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);

            // so when the target rotates toward the player then we can move the target to forward direction,
            // Suppose it Chases the player
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

        }
        else
        {
            GetComponent<Animator>().SetBool("Walking", false);
        }

        // Attack region,
        if (Distance <= Attack_range)
        {
            GetComponent<Animator>().SetBool("Attack", true);

        }


    }



    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Attack_range);

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, Chase_Range);



    }



}
