using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogueObject : MonoBehaviour
{
    //series of events that interacting causes
    public UnityEvent[] eventSeries;

    //object components
    public GameObject interactIcon;

    //player complonents
    GameObject player;
    public CollectedData interactConditions;
    //boolList 0 = can interacting
    //boolList 1 = currently interacting

    //common manager scripts for common use
    DialogueRunner dialogueFunction;
    public List<StringData> dialogue;
    public IntData dialogueInstance;
    public CollectedData activeDialogue;

    public GameObjectData textObject;
    public GameObject speechBubble;

    // Start is called before the first frame update
    void Start()
    {
        dialogueFunction = FindObjectOfType<DialogueRunner>();
        player = GameObject.FindGameObjectWithTag("Player");
        interactIcon.SetActive(false);
        speechBubble.SetActive(false);
 
    }

    private void Update()
    {
        if (interactConditions.boolList[0] == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                interactConditions.boolList[1] = true;
                interactConditions.boolList[0] = false;
                interactIcon.SetActive(false);
                speechBubble.SetActive(true);
                textObject.obj = speechBubble;
                activeDialogue.stringList = dialogue[dialogueInstance.value].listValues;
                dialogueFunction.startDialogue();

            }
        }
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactIcon.SetActive(true);
            interactConditions.boolList[0] = true;

        }
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactIcon.SetActive(false);
            interactConditions.boolList[0] = false;

        }
    }



}
