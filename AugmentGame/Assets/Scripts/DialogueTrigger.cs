using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Events;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueData charDialogue;
    InteractObject instance;

    Text displayedDialogue;

    public GameObject speechBubble;
    public GameObject interactIcon;
    public BoolData movementPause;
    public EmoteData emotes;

    Camera cam;

    EmoteManager emoteMan;

    void Start()
    {
        GameObject dialogueObj = GameObject.FindGameObjectWithTag("Dialogue");
        displayedDialogue = dialogueObj.GetComponent<Text>();
        instance = GetComponent<InteractObject>();
        emoteMan = FindObjectOfType<EmoteManager>();
        speechBubble.SetActive(false);
        displayedDialogue.text = null;
        cam = FindObjectOfType<Camera>();
    }

    public void beginDialogue()
    {
        //hault player
        movementPause.value = true;
        Debug.Log("PlayerStopped");
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

        emotes.yes = charDialogue.yes;
        emotes.no = charDialogue.no;
        emotes.wave = charDialogue.wave;
        emotes.score = charDialogue.score;
        emotes.thumbsUp = charDialogue.thumbsUp;
        emotes.shrug = charDialogue.shrug;
        emotes.fuckOff = charDialogue.fuckOff;
        emotes.watchingYou = charDialogue.watchingYou;
        emotes.rockOut = charDialogue.rockOut;
        emotes.facePalm = charDialogue.facePalm;
        emotes.oops = charDialogue.oops;
        emotes.pullHair = charDialogue.pullHair;
        emotes.salute = charDialogue.salute;
        emotes.bringItOn = charDialogue.bringItOn;
        emotes.surrender = charDialogue.surrender;
        emotes.smoke = charDialogue.smoke;

    }

    public void cycleDialogue()
    {
        charDialogue.sentNumber++;
        charDialogue.sentence = charDialogue.sentences[charDialogue.sentNumber];
        displayedDialogue.text = charDialogue.sentence;

        if(charDialogue.sentNumber == charDialogue.sentences.Count - 1)
        {
            if (charDialogue.response == true) instance.response = true;
            else instance.ended = true;
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
        Debug.Log("Reply");
        //hide npc speech bubble
        speechBubble.SetActive(false);
        displayedDialogue.text = null;
        emoteMan.emoteMenuPopUp();
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
