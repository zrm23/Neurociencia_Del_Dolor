using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Puertas1: MonoBehaviour
{
    AudioSource fuenteAudio1;
    
    void Start()
    {
        fuenteAudio1 = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
        fuenteAudio1.Play();
        }
    }

    
}
