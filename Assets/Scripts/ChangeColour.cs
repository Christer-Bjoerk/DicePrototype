using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    [SerializeField] private List<Material> diceMaterials = new List<Material>();
    [SerializeField] private MeshRenderer diceMesh;

    private void OnEnable()
    {
        EventManager.onRollingDice += ChangeDiceColour;
    }

    private void OnDisable()
    {
        EventManager.onRollingDice -= ChangeDiceColour;
    }

    private void ChangeDiceColour(int diceNumber)
    {
        for (int i = 0; i < diceMaterials.Count; i++)
        {
            if (i == diceNumber)
            {
                diceMesh.material = diceMaterials[i];
            }
        }
    }
}
