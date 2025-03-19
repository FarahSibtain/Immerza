using System;
using UnityEngine;

public class SendingLoveManager : MonoBehaviour
{
    private void Start()
    {
        OnWindowExitHover();
    }
    private void OnEnable()
    {
        SmileyManager.WindowHoverEnter += OnWindowHoverEnter;
        SmileyManager.WindowHoverExit += OnWindowExitHover;
    }    

    private void OnDisable()
    {
        SmileyManager.WindowHoverEnter -= OnWindowHoverEnter;
        SmileyManager.WindowHoverExit -= OnWindowExitHover;
    }

    private void OnWindowHoverEnter()
    {
        ParticleSystem[] particleSystems = GetComponentsInChildren<ParticleSystem>();
        foreach (ParticleSystem particleSystem in particleSystems)
        {
            particleSystem.Play();
        }
    }
    private void OnWindowExitHover()
    {
        ParticleSystem[] particleSystems = GetComponentsInChildren<ParticleSystem>();
        foreach (ParticleSystem particleSystem in particleSystems)
        {
            particleSystem.Stop();
        }
    }
}
