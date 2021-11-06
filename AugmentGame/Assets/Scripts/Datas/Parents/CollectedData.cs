using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CollectedData : ScriptableObject
{

    public int intValue;
    public List<int> intList;

    public bool boolValue;
    public List<bool> boolList;

    public float floatValue;
    public List<float> floatList;

    public string stringValue;
    public List<string> stringList;

    public Vector2 transformData;
    public List<Vector2> transformList;

    public CollectedData colData;
    public List<CollectedData> colDataList;


}
