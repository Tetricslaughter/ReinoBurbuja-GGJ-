using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public string id;
    public float damage;
    public float fireRate;
    public int maxAmmo;

   public abstract void Shoot();
}
