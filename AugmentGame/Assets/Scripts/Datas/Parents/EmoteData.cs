using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EmoteData : ScriptableObject
{
    public bool gunHeld;
    public bool gunFired;

    //facing direction bools
    public bool right;

    //inventory status of emote
    public bool yes;
    public bool no;
    public bool wave;
    public bool score;
    public bool thumbsUp;
    public bool shrug;
    public bool fuckOff;
    public bool watchingYou;
    public bool rockOut;
    public bool facePalm;
    public bool oops;
    public bool pullHair;
    public bool salute;
    public bool bringItOn;
    public bool surrender;
    public bool smoke;

    //emote started bool status
    public bool emoteInitialized;

    public bool yesInit;
    public bool noInit;
    public bool waveInit;
    public bool scoreInit;
    public bool thumbsUpInit;
    public bool shrugInit;
    public bool fuckOffInit;
    public bool watchingYouInit;
    public bool rockOutInit;
    public bool facePalmInit;
    public bool oopsInit;
    public bool hairPullInit;
    public bool saluteInit;
    public bool bringItOnInit;
    public bool surrenderInit;
    public bool smokeInit;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void reset()
    {
        yes = true;
        no = true;
        wave = true;
        score = true;
        thumbsUp = true;
        shrug = true;
        fuckOff = true;
        watchingYou = true;
        rockOut = true;
        facePalm = true;
        oops = true;
        pullHair = true;
        salute = true;
        bringItOn = true;
        surrender = true;
        smoke = true;
        emoteInitialized = false;
        yesInit = false;
        noInit = false;
        waveInit = false;
        scoreInit = false;
        thumbsUpInit = false;
        shrugInit = false;
        fuckOffInit = false;
        watchingYouInit = false;
        rockOutInit = false;
        facePalmInit = false;
        oopsInit = false;
        hairPullInit = false;
        saluteInit = false;
        bringItOnInit = false;
        surrenderInit = false;
        smokeInit = false;
    }
}
