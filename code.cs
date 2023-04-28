using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    private AudioSource my_audio;

    // Start is called before the first frame update
    void Start()
    {
        my_audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Collectible")
        { 
            my_audio.Play();
            Destroy(collision.gameObject);
        }
    }
}



