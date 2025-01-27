using UnityEngine;
using UnityEngine.InputSystem;

public class Minigun : Weapon
{
   
    [SerializeField] GameObject pistol;
    [SerializeField] GameObject minigun;
    [SerializeField] ParticleSystem particleSystem;
    public SonidoDisparo sonidoDisparo;

    [SerializeField] GameObject pistolModel;
    [SerializeField] GameObject minigunModel;


    public float timeCount;
    
    void Start()
    {
        timeCount = 0;
        this.id = "Ametralladora";
        this.damage = 3.0f;
        this.maxAmmo = 300;
       
    }

    
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && minigun.activeInHierarchy)
        {
           Shoot();
            sonidoDisparo.PlayClip(1);
        }
        if (Input.GetMouseButtonUp(0)) 
        {
           particleSystem.Stop();
           sonidoDisparo.StopClip();
        }
        if (Input.GetMouseButton(0) && minigun.activeInHierarchy)
        {
            timeCount += 1 * Time.deltaTime;
            
        }
      
        if (timeCount > 8) 
        {
          minigun.SetActive(false);
            sonidoDisparo.StopClip();
            pistol.SetActive(true);
            minigunModel.SetActive(false);
            pistolModel.SetActive(true);
            timeCount = 0;
        //    scriptMinigun.enabled = false;
        //    scriptPistol.enabled = true;
        }
        
        
    }
    public override void Shoot()
    {
        
      //Instantiate(projectile,cannon.position,cannon.rotation);
      //gun.SetActive(true);
      particleSystem.Play();
        
    }

}
