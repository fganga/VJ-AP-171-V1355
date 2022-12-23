using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    //Creamos objeto de la clase AudioSource
    public AudioSource audio1;
    public AudioSource audioBack;
    public AudioSource audioMusica;

    //Creamos GameObject para cada botón
    public GameObject boton1,boton2,boton3;
    //Método para iniciar el sonido
    public void PlayAudio1(){
        audio1.Play();
        audioBack.Stop();
        audioMusica.Play();
        //Manejo de botones
        boton1.SetActive(false);
        boton2.SetActive(true);
        boton3.SetActive(true);
    }    
}
