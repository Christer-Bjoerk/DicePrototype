using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    [SerializeField] private List<ParticleSystem> particles = new List<ParticleSystem>();

    private void OnEnable()
    {
        EventManager.PlayParticles += PlayParticleInt;
    }

    private void OnDisable()
    {
        EventManager.PlayParticles -= PlayParticleInt;
    }

    private void PlayParticleInt(int diceNumber)
    {
        for (int i = 0; i < particles.Count; i++)
        {
            if (i == diceNumber)
            {
                particles[i].Play();
            }
        }
    }
}
