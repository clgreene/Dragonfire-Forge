using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Events;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueParentData charDialogue;
    InteractObject instance;

    Text displayedDialogue;

    public GameObject speechBubble;
    public GameObject interactIcon;
    public BoolData movementPause;
    public EmoteData emotes;
    List<int> responseNumber;

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

    private void Update()
    {
        if (instance.started == true && instance.ended == false)
        {
            movementPause.value = true;
        }
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
        charDialogue.initialize();
        if(charDialogue.currentDialogue.random == true)
        {
            charDialogue.currentDialogue.sentNumber = Random.Range(0, charDialogue.currentDialogue.sentences.Count);
            instance.ended = true;
        }
        else charDialogue.currentDialogue.sentNumber = 0;

        charDialogue.currentDialogue.sentence = charDialogue.currentDialogue.sentences[charDialogue.currentDialogue.sentNumber];
        displayedDialogue.text = charDialogue.currentDialogue.sentence;

        emotes.yes = charDialogue.currentDialogue.yes;
        emotes.no = charDialogue.currentDialogue.no;
        emotes.wave = charDialogue.currentDialogue.wave;
        emotes.score = charDialogue.currentDialogue.score;
        emotes.thumbsUp = charDialogue.currentDialogue.thumbsUp;
        emotes.shrug = charDialogue.currentDialogue.shrug;
        emotes.fuckOff = charDialogue.currentDialogue.fuckOff;
        emotes.watchingYou = charDialogue.currentDialogue.watchingYou;
        emotes.rockOut = charDialogue.currentDialogue.rockOut;
        emotes.facePalm = charDialogue.currentDialogue.facePalm;
        emotes.oops = charDialogue.currentDialogue.oops;
        emotes.pullHair = charDialogue.currentDialogue.pullHair;
        emotes.salute = charDialogue.currentDialogue.salute;
        emotes.bringItOn = charDialogue.currentDialogue.bringItOn;
        emotes.surrender = charDialogue.currentDialogue.surrender;
        emotes.smoke = charDialogue.currentDialogue.smoke;

    }

    public void cycleDialogue()
    {
        charDialogue.currentDialogue.sentNumber++;
        charDialogue.currentDialogue.sentence = charDialogue.currentDialogue.sentences[charDialogue.currentDialogue.sentNumber];
        displayedDialogue.text = charDialogue.currentDialogue.sentence;

        if(charDialogue.currentDialogue.sentNumber == charDialogue.currentDialogue.sentences.Count - 1)
        {
            if (charDialogue.currentDialogue.response == true) instance.response = true;
            else instance.ended = true;
        }
    }

    public void endDialogue()
    {
        //endDialogue needs a unity event system for different outcomes, i.e. if you must respond, or certain changes happen because of the dialogue, or the characters next dialogue string they give you should change.

        emotes.reset();
        speechBubble.SetActive(false);
        displayedDialogue.text = null;
        charDialogue.currentDialogue.sentNumber = 0;
        movementPause.value = false;


    }

    public void response()
    {
        Debug.Log("Reply");
        //hide npc speech bubble
        speechBubble.SetActive(false);
        displayedDialogue.text = null;
        charDialogue.currentDialogue.sentNumber = 0;
        emoteMan.emoteMenuPopUp();
        instance.waiting = true;

        //character response script will compare unlocked emotes against current dialogue accepted emote to display what responses are allowed
        //response list number will change a response int, which dialogue data will compare and select the appropriate npc continuation

    }

    public void branchContinue()
    {
        Debug.Log("I waiting for the emote to start");
        //pull from emote data what emote is playing, assign number.

        StartCoroutine(waitForEmote());

        //check if response is available, then check if it is the one being played. if so,
        //assign the corresponding branch of dialogue to currrent dialogue.
        int i = 0;
        if (charDialogue.currentDialogue.yes == true)
        {
            i++;
            if (emotes.yesInit == true)
            {
                charDialogue.currentDialogue = charDialogue.currentDialogue.dialogues[responseNumber[i - 1]];
            }
        }

    }

    public void finishDialogue()
    {
        speechBubble.SetActive(false);
        displayedDialogue.text = null;
        movementPause.value = false;
    }


    IEnumerator waitForEmote()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("I waited for the emote to finish");
    }
}
