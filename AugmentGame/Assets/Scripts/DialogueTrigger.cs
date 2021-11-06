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
        charDialogue.sentNumber = 0;
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


        speechBubble.SetActive(false);
        displayedDialogue.text = null;
        charDialogue.sentNumber = 0;
        movementPause.value = false;
    }

    public void response()
    {
        speechBubble.SetActive(false);
        displayedDialogue.text = null;
        //ask for a response function
    }

    public void finishDialogue()
    {
        speechBubble.SetActive(false);
        displayedDialogue.text = null;
        movementPause.value = false;
    }
}
