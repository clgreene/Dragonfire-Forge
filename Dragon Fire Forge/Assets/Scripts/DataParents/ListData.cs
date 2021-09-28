using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class ListData : ScriptableObject
{

    public List<Vector3> positionValue;
    public List<bool> boolValue;
    public bool listSet;
    public bool listOver;
    public int number;

    // Start is called before the first frame update
    void Start()
    {
        listSet = false;
        number = 0;
        listOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
