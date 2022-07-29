using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private ScriptableAudioBank playerAudioBank;

    public void HitPlayerSFX()
    {
        audioSource.PlayOneShot(playerAudioBank.Hit);
    }
    
    public void PlayerDeathSFX()
    {
        audioSource.PlayOneShot(playerAudioBank.Death);
    }
    
    public void PlayerNearDeathSFX()
    {
        audioSource.clip = playerAudioBank.HeartBeat;
        audioSource.pitch = 1.5f;
        audioSource.Play();
    }
}