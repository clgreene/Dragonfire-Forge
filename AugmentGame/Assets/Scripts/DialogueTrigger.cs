using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Events;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueData charDialogue;
    public InteractObject instance;

    Text displayedDialogue;

    public GameObject speechBubble;
    public GameObject interactIcon;
    public BoolData movementPause;

    Camera cam;

    void Start()
    {
        GameObject dialogueObj = GameObject.FindGameObjectWithTag("Dialogue");
        displayedDialogue = dialogueObj.GetComponent<Text>();
        speechBubble.SetActive(false);
        displayedDialogue.text = null;
        cam = FindObjectOfType<Camera>();
    }

    public void beginDialogue()
    {
        //hault player
        movementPause.value = true;
        //display speech bubble
        speechBubble.SetActive(true);
        //set UI dialogue text on top of speech bubble
        Vector2 screenPosition = cam.WorldToScreenPoint(speechBubble.transform.position);
        displayedDialogue.transform.position = screenPosition;
        //set dialogue to first sentence and display it on screen
        if(charDialogue.random == true)
        {
            charDialogue.sentNumber = Random.Range(0, charDialogue.sentences.Count);
            instance.ended = true;
        }
        else charDialogue.sentNumber = 0;

        charDialogue.sentence = charDialogue.sentences[charDialogue.sentNumber];
        displayedDialogue.text = charDialogue.sentence;

    }

    public void cycleDialogue()
    {
        charDialogue.sentNumber++;
        charDialogue.sentence = charDialogue.sentences[charDialogue.sentNumber];
        displayedDialogue.text = charDialogue.sentence;

        if(charDialogue.sentNumber == charDialogue.sentences.Count - 1)
        {
            instance.ended = true;
        }
    }

    public void endDialogue()
    {
        //endDialogue needs a unity event system for different outcomes, i.e. if you must respond, or certain changes happen because of the dialogue, or the characters next dialogue string they give you should change.
        if(charDialogue.response == true)
        {
            response();
        }

        speechBubble.SetActive(false);
        displayedDialogue.text = null;
        charDialogue.sentNumber = 0;
        movementPause.value = false;
    }

    public void response()
    {
        speechBubble.SetActive(false);
        displayedDialogue.text = null;
        //ask for a response function from character response script
        //character response script will compare unlocked emotes against current dialogue accepted emote to display what responses are allowed
        //response list number will change a response int, which dialogue data will compare and select the appropriate npc continuation

    }

    public void finishDialogue()
    {
        speechBubble.SetActive(false);
        displayedDialogue.text = null;
        movementPause.value = false;
    }
}
