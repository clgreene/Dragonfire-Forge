using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmoteManager : MonoBehaviour
{

    public EmoteData emotes;
    public Animator animator;
    GameObject player;
    public IntData emoteWheelInt;
    public BoolData emoteSelectionOn;
    public BoolData movementPause;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        animator = player.GetComponent<Animator>();
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
