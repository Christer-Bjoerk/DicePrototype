using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    [SerializeField] private ParticleSystem particle;
    [SerializeField] private List<ParticleSystem> particles = new List<ParticleSystem>();

    private void OnEnable()
    {
        EventManager.PlayParticles += PlayParticleInt;
    }

    private void OnDisable()
    {
        EventManager.PlayParticles -= PlayParticleInt;
    }

    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }

    public void PlayParticle()
    {
        particle.Play();
    }

    private void PlayParticleInt(int diceNumber)
    {
        for (int i = 0; i <= particles.Count; i++)
        {
            if (i == diceNumber)
            {
                particles[i].Play();
            }
        }
    }
}
