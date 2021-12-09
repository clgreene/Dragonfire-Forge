using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DialogueData : ScriptableObject
{
    public bool random;

    public int sentNumber;
    public string sentence;
    public List<string> sentences;

    public bool response;
    public bool end;

    public int dialNumber;
    public DialogueData dialogue;
    public List<DialogueData> dialogues;


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



    public void initializeDictionary()
    {
        
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
