using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxScript : MonoBehaviour
{

    public Camera cam;

    public Transform player;

    Vector2 startPos;
    float startZ;

    float playerDistance => transform.position.z - player.position.z;
    float farthestDistance => (cam.transform.position.z + (playerDistance > 0 ? cam.farClipPlane : cam.nearClipPlane));

    float parallaxFactor => Mathf.Abs(playerDistance) / farthestDistance;

    Vector2 travel => (Vector2)cam.transform.position - startPos;


    void Start()
    {
        startPos = transform.position;
        startZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = startPos + travel * parallaxFactor;
        transform.position = new Vector3(newPos.x, newPos.y, startZ);
    }
}
