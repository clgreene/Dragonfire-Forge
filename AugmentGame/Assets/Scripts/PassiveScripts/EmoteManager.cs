using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmoteManager : MonoBehaviour
{

    public EmoteData emotes;
    public Animator animator;
    public IntData emoteWheelInt;

    void Start()
    {
        
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
        //animator.SetBool("wave", emotes.waveInit);
        //animator.SetBool("wave", emotes.waveInit);
        //animator.SetBool("wave", emotes.waveInit);
        //animator.SetBool("wave", emotes.waveInit);
        //animator.SetBool("wave", emotes.waveInit);
        //animator.SetBool("wave", emotes.waveInit);
        //animator.SetBool("wave", emotes.waveInit);
        //animator.SetBool("wave", emotes.waveInit);

    }

    public void selectionOne()
    {
        switch (emoteWheelInt.value)
        {
            case 0:
                wave();
                break;
            case 1:
                rockOut();
                break;
        }

    }

    public void selectionTwo()
    {
        switch (emoteWheelInt.value)
        {
            case 0:
                fuckOff();
                break;
            case 1:
                score();
                break;
        }

    }

    public void selectionThree()
    {
        switch (emoteWheelInt.value)
        {
            case 0:
                bringItOn();
                break;
            case 1:
                smoke();
                break;
        }

    }

    public void selectionFour()
    {
        switch (emoteWheelInt.value)
        {
            case 0:
                salute();
                break;
            case 1:
                no();
                break;
        }

    }

    public void selectionFive()
    {
        switch (emoteWheelInt.value)
        {
            case 0:
                thumbsUp();
                break;
            case 1:
                yes();
                break;
        }

    }

    public void selectionSix()
    {
        switch (emoteWheelInt.value)
        {
            case 0:
                surrender();
                break;
            case 1:
                facePalm();
                break;
        }

    }

    public void selectionSeven()
    {
        switch (emoteWheelInt.value)
        {
            case 0:
                watchingYou();
                break;
            case 1:
                oops();
                break;
        }

    }

    public void selectionEight()
    {
        switch (emoteWheelInt.value)
        {
            case 0:
                shrug();
                break;
            case 1:
                pullHair();
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

    // Start is called before the first frame update

}
