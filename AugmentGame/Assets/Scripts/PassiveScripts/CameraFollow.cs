using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        transform.position = new Vector3(0, 0, -5);
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector2 newPos = player.transform.position;
        transform.position = new Vector3(newPos.x, newPos.y, transform.position.z);
    }
}
