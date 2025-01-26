using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class Pistol : Weapon
{

    [SerializeField] ParticleSystem particleSystem;
    public SonidoDisparo sonidoDisparo;
   
    float nextShot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Start()
    {
        this.id = "Pistola";
        this.damage = 3.0f;
        //this.fireRate = 0.7f;
        nextShot = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= nextShot )
        {
            nextShot = Time.time + fireRate;
            Shoot();
            sonidoDisparo.PlayClip(0);
        }
        if (Input.GetMouseButtonUp(0))
        {
            particleSystem.Stop();
        }
        
    }
    public override void Shoot()
    {
        particleSystem.Play();
    }
}
