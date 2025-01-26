using UnityEngine;

public class SonidoDisparo : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip burbuja;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayClip()
    {
        AudioSource.PlayOneShot(burbuja);
    }
    public void PlayClipontinou()
    {
        AudioSource.Play();
    }
}
