using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
	private AudioSource sound;

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    public void playSound()
    {
        sound.Play();
    }
}
