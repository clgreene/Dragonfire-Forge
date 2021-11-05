using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueTransformUpdate : MonoBehaviour
{
    Camera cam;
    Text dialogue;

    public GameObjectData speechBubble;


    // Start is called before the first frame update
    void Start()
    {
        dialogue = GetComponent<Text>();
        cam = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (speechBubble.obj != null)
        {
            Vector2 screenPosition = cam.WorldToScreenPoint(speechBubble.obj.transform.position);
            dialogue.transform.position = screenPosition;
        }


        
    }
}
