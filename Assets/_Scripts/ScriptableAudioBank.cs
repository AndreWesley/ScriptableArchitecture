using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AudioBank", menuName = "SidiaTeaches/AudioBank", order = 0)]
public class ScriptableAudioBank : ScriptableObject
{
    [SerializeField] private AudioClip hit;
    [SerializeField] private AudioClip death;
    [SerializeField] private AudioClip heartBeat;
    
    public AudioClip Hit => hit;
    public AudioClip Death => death;
    public AudioClip HeartBeat => heartBeat;
}
