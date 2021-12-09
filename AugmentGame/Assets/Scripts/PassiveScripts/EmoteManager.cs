using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmoteManager : MonoBehaviour
{

    public EmoteData emotes;
    Animator animator;
    GameObject player;
    public IntData emoteWheelInt;
    public BoolData emoteSelectionOn;
    public BoolData movementPause;

    public GameObject emoteMenu;
    GameObject newEmote;
    Transform uiCanvas;
    Vector3 mousePos;




    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        animator = player.GetComponent<Animator>();
        uiCanvas = GameObject.FindGameObjectWithTag("UI").transform;

    }

    private void Update()
    {
        animator.SetBool("wave", emotes.waveInit);
        animator.SetBool("shrug", emotes.shrugInit);
        animator.SetBool("hairPull", emotes.hairPullInit);
        animator.SetBool("watchingYou", emotes.watchingYouInit);
        animator.SetBool("surrender", emotes.surrenderInit);
        animator.SetBool("smoke", emotes.smokeInit);
        animator.SetBool("oops", emotes.oopsInit);
        animator.SetBool("fuckYou", emotes.fuckOffInit);
        animator.SetBool("comeHere", emotes.bringItOnInit);
        animator.SetBool("facePalm", emotes.facePalmInit);
        animator.SetBool("no", emotes.noInit);
        animator.SetBool("yes", emotes.yesInit);
        animator.SetBool("salute", emotes.saluteInit);
        animator.SetBool("score", emotes.scoreInit);
        animator.SetBool("thumbsUp", emotes.thumbsUpInit);
        animator.SetBool("rockOut", emotes.rockOutInit);



    }

    public void emoteMenuPopUp()
    {

        movementPause.value = true;
        emoteSelectionOn.value = true;
        emoteWheelInt.value = 0;

        mousePos = Input.mousePosition;

        newEmote = Instantiate(emoteMenu, transform.position, Quaternion.identity);

        newEmote.transform.SetParent(uiCanvas);
        newEmote.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        newEmote.transform.position = mousePos;

        newEmote.GetComponent<EmoteDisplay>().swapDisplay();

       
    }

    public void emoteSwap(int keyStroke)
    {
        switch (keyStroke)
        {
            case 0:
                emoteWheelInt.value = 0;
                newEmote.GetComponent<EmoteDisplay>().swapDisplay();
                break;
            case 1:
                emoteWheelInt.value = 1;
                newEmote.GetComponent<EmoteDisplay>().swapDisplay();
                break;
        }
    }

    public void emoteMenuExit()
    {
        if (newEmote != null) Destroy(newEmote);
        emoteSelectionOn.value = false;
        if (emotes.emoteInitialized == true) movementPause.value = true;
        else movementPause.value = false;
        Debug.Log("shouldn't be running");
    }

    //play either wave or rockout emote
    public void selectionOne()
    {
        emotes.emoteInitialized = true;
        switch (emoteWheelInt.value)
        {
            
            case 0:
                wave();                
                emoteSelectionOn.value = false;
                break;
            case 1:
                rockOut();
                emoteSelectionOn.value = false;
                break;
        }
        emoteMenuExit();

    }

    //play either fuck off or score emote
    public void selectionTwo()
    {
        emotes.emoteInitialized = true;
        switch (emoteWheelInt.value)
        {

            case 0:
                fuckOff();
                emoteSelectionOn.value = false;
                break;
            case 1:
                score();
                emoteSelectionOn.value = false;
                break;
        }
        emoteMenuExit();
    }

    //play either bring it or smoking emote
    public void selectionThree()
    {
        emotes.emoteInitialized = true;
        switch (emoteWheelInt.value)
        {
            case 0:
                bringItOn();
                emoteSelectionOn.value = false;
                break;
            case 1:
                smoke();
                emoteSelectionOn.value = false;
                break;
        }
        emoteMenuExit();
    }

    //play either salute or no emote
    public void selectionFour()
    {
        emotes.emoteInitialized = true;
        switch (emoteWheelInt.value)
        {
            case 0:
                salute();
                emoteSelectionOn.value = false;
                break;
            case 1:
                no();
                emoteSelectionOn.value = false;
                break;
        }
        emoteMenuExit();
    }

    //play either thumbs up or yes emote
    public void selectionFive()
    {
        emotes.emoteInitialized = true;
        switch (emoteWheelInt.value)
        {
            case 0:
                thumbsUp();
                emoteSelectionOn.value = false;
                break;
            case 1:
                yes();
                emoteSelectionOn.value = false;
                break;
        }
        emoteMenuExit();
    }

    //play either surrender or facepalm emote
    public void selectionSix()
    {
        emotes.emoteInitialized = true;
        switch (emoteWheelInt.value)
        {
            case 0:
                surrender();
                emoteSelectionOn.value = false;
                break;
            case 1:
                facePalm();
                emoteSelectionOn.value = false;
                break;
        }
        emoteMenuExit();
    }

    //play either watching you or oop emote
    public void selectionSeven()
    {
        emotes.emoteInitialized = true;
        switch (emoteWheelInt.value)
        {
            case 0:
                watchingYou();
                emoteSelectionOn.value = false;
                break;
            case 1:
                oops();
                emoteSelectionOn.value = false;
                break;
        }
        emoteMenuExit();
    }

    //play either shrug or pull hair emote
    public void selectionEight()
    {
        emotes.emoteInitialized = true;
        switch (emoteWheelInt.value)
        {
            case 0:
                shrug();
                emoteSelectionOn.value = false;
                break;
            case 1:
                pullHair();
                emoteSelectionOn.value = false;
                break;
        }
        emoteMenuExit();
    }



    public void wave()
    {
        emotes.waveInit = true;
        animator.Play("Emote");

    }

    public void score()
    {
        emotes.scoreInit = true;
        animator.Play("Emote");
    }

    public void thumbsUp()
    {
        emotes.thumbsUpInit = true;
        animator.Play("Emote");
    }

    public void shrug()
    {
        emotes.shrugInit = true;
        animator.Play("Emote");
    }

    public void fuckOff()
    {
        emotes.fuckOffInit = true;
        animator.Play("Emote");
    }

    public void watchingYou()
    {
        emotes.watchingYouInit = true;
        animator.Play("Emote");
    }

    public void rockOut()
    {
        emotes.rockOutInit = true;
        animator.Play("Emote");
    }

    public void facePalm()
    {
        emotes.facePalmInit = true;
        animator.Play("Emote");
    }

    public void oops()
    {
        emotes.oopsInit = true;
        animator.Play("Emote");
    }

    public void pullHair()
    {
        emotes.hairPullInit = true;
        animator.Play("Emote");
    }

    public void salute()
    {
        emotes.saluteInit = true;
        animator.Play("Emote");
    }

    public void bringItOn()
    {
        emotes.bringItOnInit = true;
        animator.Play("Emote");
    }

    public void surrender()
    {
        emotes.surrenderInit = true;
        animator.Play("Emote");
    }

    public void smoke()
    {
        emotes.smokeInit = true;
        animator.Play("Emote");
    }

    public void no()
    {
        emotes.noInit = true;
        animator.Play("Emote");
    }

    public void yes()
    {
        emotes.yesInit = true;
        animator.Play("Emote");
    }


}
