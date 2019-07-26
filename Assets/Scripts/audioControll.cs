using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioControll : MonoBehaviour
{
  public AudioSource audioSourceIntro;
public AudioSource audioSourceLoop;
private bool startedLoop;

void FixedUpdate()
{
    if (!audioSourceIntro.isPlaying && !startedLoop)
    {
        audioSourceLoop.Play();
        Debug.Log("Done playing");
        startedLoop = true;
    }
}
}
