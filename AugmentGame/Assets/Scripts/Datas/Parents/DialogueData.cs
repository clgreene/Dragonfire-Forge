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

    public int dialNumber;
    public DialogueData dialogue;
    public List<DialogueData> dialogues;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
