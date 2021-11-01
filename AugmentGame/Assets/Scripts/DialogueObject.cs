using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueObject : MonoBehaviour
{
    
    public List<StringData> dialogue;
    public IntData dialogueInstance;

    DialogueRunner activeDialogue;

    GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        activeDialogue = FindObjectOfType<DialogueRunner>();
        player = FindObjectOfType<EVE>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //enable button icon
            //
        }
    }

}
