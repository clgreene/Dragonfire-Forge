using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float moveSpeed = 300;
    public float jumpForce;
    
    Rigidbody2D RB;

    public CollectedData jumpData;
    //jumpData.intList = jump count and jump max respectively
    //jumpData.boolValue = groundCheck

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.D) && RB.velocity.x < 0.6f) RB.AddForce(transform.right * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A) && RB.velocity.x > -0.6f) RB.AddForce(transform.right * -moveSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && jumpData.intList[0] < jumpData.intList[1])
        {
            RB.velocity = new Vector2(0, 0);
            RB.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            jumpData.intList[0]++;
        }

        if (jumpData.boolValue == true) jumpData.intList[0] = 0;
    }

}
