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

    public BoolData movementPause;
    //condition[1] bool being true cancels movement abilities.

    //emote data
    public EmoteData emotes;
    public CollectedData jumpData;
    //jumpData.intList = jump count and jump max respectively
    //jumpData.boolValue = groundCheck

    public GameObject emoteMenu;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        triggerRight = interactTrigger.offset;
        triggerLeft.y = triggerRight.y;
        triggerLeft.x = -triggerRight.x;
        movementPause.value = false;
    }

    // Update is called once per frame
    void Update()
    {
        

        animator.SetFloat("Speed", RB.velocity.x);
        animator.SetBool("interacting", movementPause.value);
        animator.SetBool("wave", emotes.waveInit);
        animator.SetBool("shrug", emotes.shrugInit);
        animator.SetBool("gun", emotes.gunHeld);
        

        //wasd player input for movement
        if (movementPause.value == false)
        {
            if (Input.GetKey(KeyCode.D) && RB.velocity.x < 0.6f)
            {
                RB.AddForce(transform.right * moveSpeed * Time.deltaTime); // walk right
                interactTrigger.offset = triggerRight;
                animator.SetBool("facingRight", true);
            }
            if (Input.GetKey(KeyCode.A) && RB.velocity.x > -0.6f)
            {
                RB.AddForce(transform.right * -moveSpeed * Time.deltaTime); // walk left
                interactTrigger.offset = triggerLeft;
                animator.SetBool("facingRight", false);
            }


            if (Input.GetKeyDown(KeyCode.Space) && jumpData.intList[0] < jumpData.intList[1])
            {
                RB.velocity = new Vector2(0, 0);
                RB.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
                jumpData.intList[0]++;
            }

            if (jumpData.boolValue == true) jumpData.intList[0] = 0;
        }

        //emote menu popup
        if (Input.GetKeyDown(KeyCode.E))
        {
            movementPause.value = true;

            

        }

        if (Input.GetKeyUp(KeyCode.E)) movementPause.value = false;

        
    }


}
