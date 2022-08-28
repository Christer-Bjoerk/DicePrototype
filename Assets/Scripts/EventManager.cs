using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void OnRollingDice(int diceNumber);
    public static OnRollingDice onRollingDice;

    public static Action PlayParticle;
    public static Action<int> PlayParticles;
}