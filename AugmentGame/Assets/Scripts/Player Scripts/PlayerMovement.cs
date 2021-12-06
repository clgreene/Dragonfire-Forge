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
    EmoteManager emoteMan;
    //jumpData.intList = jump count and jump max respectively
    //jumpData.boolValue = groundCheck

    public GameObject emoteMenu;
    public BoolData emoteSelectionOn;
    public IntData emoteWheelInt;
    public Transform uiCanvas;
    public Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        emoteMan = FindObjectOfType<EmoteManager>();
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
        animator.SetBool("shrug", emotes.shrugInit);
        animator.SetBool("gun", emotes.gunHeld);
        

        //wasd player input for movement
        if (movementPause.value == false)
        {
            if (Input.GetKey(KeyCode.D) && RB.velocity.x < 0.6f)
            {
                RB.AddForce(transform.right * moveSpeed * Time.deltaTime); // walk right
                interactTrigger.offset = triggerRight;
                emotes.right = true;
                animator.SetBool("facingRight", emotes.right);
            }
            if (Input.GetKey(KeyCode.A) && RB.velocity.x > -0.6f)
            {
                RB.AddForce(transform.right * -moveSpeed * Time.deltaTime); // walk left
                interactTrigger.offset = triggerLeft;
                emotes.right = false;
                animator.SetBool("facingRight", emotes.right);
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
        if (Input.GetKeyDown(KeyCode.E) && movementPause.value == false)
        {
            emoteSelectionOn.value = true;
            emoteMan.emoteMenuPopUp();

        }

        if (emoteSelectionOn.value == true)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                emoteMan.emoteSwap(0);
            }

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                emoteMan.emoteSwap(1);
            }
        }

        if (Input.GetKeyUp(KeyCode.E) || emotes.emoteInitialized == true)
        {
            emoteMan.emoteMenuExit();

        }


        
    }


}
