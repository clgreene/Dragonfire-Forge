using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmoteManager : MonoBehaviour
{

    public EmoteData emotes;
    public Animator animator;

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
        emotes.pullHairInit = true;
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



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
