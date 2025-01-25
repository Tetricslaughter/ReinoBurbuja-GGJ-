using UnityEngine;

public class Minigun : Weapon
{
   
    [SerializeField] GameObject projectile;

    ParticleSystem particleSystem;

    public override void Shoot()
    {
       particleSystem = GetComponent<ParticleSystem>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.id = "Ametralladora";
        this.damage = 3.0f;
        this.maxAmmo = 300;
        this.fireRate = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
}
