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
    public BoolData interacting;


    //common manager scripts for common use
    DialogueRunner dialogueController;
    public List<StringData> dialogue;
    public IntData dialogueInstance;


    // Start is called before the first frame update
    void Start()
    {
        dialogueController = FindObjectOfType<DialogueRunner>();
        player = GameObject.FindGameObjectWithTag("Player");
 
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactIcon.SetActive(true);
            interacting.value = true;

        }
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            interactIcon.SetActive(false);
            interacting.value = false;
        }
    }



}
