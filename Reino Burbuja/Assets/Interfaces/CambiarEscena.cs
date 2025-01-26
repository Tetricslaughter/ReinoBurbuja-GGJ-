using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip buttonPresed;
    public AudioClip buttonPointer;
    public int nameScene;
    // Llamamos a esta funci�n para cambiar de escena
    public void CambiarEscenas(int nombre)
    {
        nameScene = nombre;
        Invoke("ChangeEscena",0.5f);
    }
    public void ChangeEscena()
    {
        SceneManager.LoadScene(nameScene);
    }

    public void PlayClip()
    {
        AudioSource.PlayOneShot(buttonPresed);
    }

    public void ClipPointerPlay()
    {
        AudioSource.PlayOneShot(buttonPointer);
    }
}