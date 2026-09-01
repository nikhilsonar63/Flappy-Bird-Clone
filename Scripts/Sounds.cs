using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource sfx;
    public AudioClip fly, hit, point, dia;
    public void play_flay()
    {
        sfx.PlayOneShot(fly);
    }
    public void play_hiit()
    {
        sfx.PlayOneShot(hit);
    }
    public void play_pointt()
    {
        sfx.PlayOneShot(point);
    }
    public void play_diaa()
    {
        sfx.PlayOneShot(dia);
    }
}
