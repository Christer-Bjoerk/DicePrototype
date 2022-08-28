using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "SO/DiceData", order = 0)]
public class DiceDataScriptableObject : ScriptableObject
{
    public Vector3 velocity;
    public bool isDiceMoving;
}
