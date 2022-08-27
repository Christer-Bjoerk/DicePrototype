using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void OnRollingDice(int diceNumber);
    public static OnRollingDice onRollingDice;
}