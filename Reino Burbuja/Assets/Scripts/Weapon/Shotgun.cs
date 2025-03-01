using UnityEngine;

public class Shotgun : Weapon
{

    [SerializeField] ParticleSystem particleSystem;
    [SerializeField] GameObject pistol;
    [SerializeField] GameObject shotgun;

    [SerializeField] GameObject pistolM;
    [SerializeField] GameObject shotgunM;
    public SonidoDisparo sonidoDisparo;

    float nextShot;
    public  int cont;
    void Start()
    {
        id = "Escopeta";
        cont = 0;
        nextShot = 0;
        //this.fireRate = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&& shotgun.activeInHierarchy && Time.time >= nextShot) 
        {
            nextShot = Time.time + fireRate;
            particleSystem.Play();
            sonidoDisparo.PlayClip(2);
            cont++;
        }
        if (Input.GetMouseButtonUp(0)) 
        {
          // particleSystem.Stop(); 
        }
        if (cont == maxAmmo) 
        {
            pistol.SetActive(true);
            shotgun.SetActive(false);

            pistolM.SetActive(true);
            shotgunM.SetActive(false);

            cont = 0;
      //      scriptShotgun.enabled =false;
      //      scriptPistol.enabled =true;
        }
        
    }
    public override void Shoot()
    {

        //Instantiate(projectile,cannon.position,cannon.rotation);
        //gun.SetActive(true);
        particleSystem.Play();
    }
}
