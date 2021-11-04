using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrounded : MonoBehaviour
{
    //establishing our BoolData variable for ground checks
    public CollectedData GC;

    //as long as player is on the ground the groundcheck bool is set to true. This requires ground objects being tagged as "Ground"
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            GC.boolValue = true;

        }


    }

    //once Groundcheck collider has left the ground we set the GroundCheck to false until we are back on the ground.
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            GC.boolValue = false;
            Debug.Log("Weeee");
        }
    }

}
