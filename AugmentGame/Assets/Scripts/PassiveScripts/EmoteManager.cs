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
    }

    public void thumbsUp()
    {
        emotes.thumbsUpInit = true;
    }

    public void shrug()
    {
        emotes.shrugInit = true;
    }

    public void fuckOff()
    {
        emotes.fuckOffInit = true;
    }

    public void watchingYou()
    {
        emotes.watchingYouInit = true;
    }

    public void rockOut()
    {
        emotes.rockOutInit = true;
    }

    public void facePalm()
    {
        emotes.facePalmInit = true;
    }

    public void oops()
    {
        emotes.oopsInit = true;
    }

    public void pullHair()
    {
        emotes.pullHairInit = true;
    }

    public void salute()
    {
        emotes.saluteInit = true;
    }

    public void bringItOn()
    {
        emotes.bringItOnInit = true;
    }

    public void surrender()
    {
        emotes.surrenderInit = true;
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
