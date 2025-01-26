using UnityEngine;

public class enemy : MonoBehaviour
{
    public EnemyLoot enemyLoot;
    int hp;
    private void Start()
    {
        hp = 100;
    }
    
    private void OnParticleCollision(GameObject other)
    {
        

        if (other.CompareTag("minigun"))
        {
            hp -= 30;
            if (hp <= 0)
            {
                enemyLoot.loot();
                Destroy(this.gameObject);
                
            }
        }
        if (other.CompareTag("shotgun"))
        {
            hp -= 40;
           
            if (hp <= 0)
            {
                enemyLoot.loot();
                Destroy(this.gameObject);

            }
        }
        if (other.CompareTag("pistol"))
        {
            hp -= 20;
            if (hp <= 0)
            {
                enemyLoot.loot();
                Destroy(this.gameObject);

            }
        }
    }
}
