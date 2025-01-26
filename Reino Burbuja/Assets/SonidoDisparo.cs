using UnityEngine;

public class SonidoDisparo : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip[] burbuja;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayClip(int sonido)
    {
        AudioSource.PlayOneShot(burbuja[sonido]);
    }
    public void StopClip()
    {
        AudioSource.Stop();
    }
    public void PlayClipontinou()
    {
        AudioSource.Play();
    }
}
