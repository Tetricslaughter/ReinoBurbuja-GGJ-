using UnityEngine;
using UnityEngine.InputSystem;

public class Minigun : Weapon
{
   
    [SerializeField] GameObject pistol;
    [SerializeField] GameObject minigun;
    [SerializeField] ParticleSystem particleSystem;
   

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
           
        }
        if (Input.GetMouseButtonUp(0)) 
        {
           particleSystem.Stop();
        }
        if (Input.GetMouseButton(0) && minigun.activeInHierarchy)
        {
            timeCount += 1 * Time.deltaTime;
        }
      
        if (timeCount > 8) 
        {
          minigun.SetActive(false);
          pistol.SetActive(true);
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
