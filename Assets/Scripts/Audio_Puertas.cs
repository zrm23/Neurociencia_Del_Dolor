using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Puertas : MonoBehaviour
{
    AudioSource fuenteAudio;
    
    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
        fuenteAudio.Play();
        }
    }

    void OnTriggerExit(Collider other){
        if (other.CompareTag("Player")){
        fuenteAudio.Stop();
        }
    }
}
