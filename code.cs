using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    [SerializeField]
    private AudioSource my_audio;

    // Start is called before the first frame update
    void Start()
    {
        if (GetComponent<AudioSource>() != null)
        {
            my_audio = GetComponent<AudioSource>();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collectible"))
        {
            AudioSource audioSource = collision.gameObject.GetComponent<AudioSource>();
            if (audioSource != null)
            {
                my_audio = audioSource;
                my_audio.Play();
                Destroy(collision.gameObject);
            }
        }
    }
}
