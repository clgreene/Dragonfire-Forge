using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float moveSpeed = 300;
    public float jumpForce;
    
    Rigidbody2D RB;
    public BoxCollider2D interactTrigger;
    Vector2 triggerRight;
    Vector2 triggerLeft;

    Animator animator;

    public CollectedData interactConditions;
    //condition[1] bool being true cancels movement abilities.

    public CollectedData jumpData;
    //jumpData.intList = jump count and jump max respectively
    //jumpData.boolValue = groundCheck

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        triggerRight = interactTrigger.offset;
        triggerLeft.y = triggerRight.y;
        triggerLeft.x = -triggerRight.x;
        interactConditions.boolList[1] = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        animator.SetFloat("Speed", RB.velocity.x);


        if (interactConditions.boolList[1] == false)
        {
            if (Input.GetKey(KeyCode.D) && RB.velocity.x < 0.6f)
            {
                RB.AddForce(transform.right * moveSpeed * Time.deltaTime); // walk right
                interactTrigger.offset = triggerRight;
            }
            if (Input.GetKey(KeyCode.A) && RB.velocity.x > -0.6f)
            {
                RB.AddForce(transform.right * -moveSpeed * Time.deltaTime); // walk left
                interactTrigger.offset = triggerLeft;
            }


            if (Input.GetKeyDown(KeyCode.Space) && jumpData.intList[0] < jumpData.intList[1])
            {
                RB.velocity = new Vector2(0, 0);
                RB.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
                jumpData.intList[0]++;
            }

            if (jumpData.boolValue == true) jumpData.intList[0] = 0;
        }
        
    }

}
