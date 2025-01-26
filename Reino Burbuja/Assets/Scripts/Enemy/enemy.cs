using UnityEngine;

public class enemy : MonoBehaviour
{

    int hp;
    private void Start()
    {
        hp = 100;
    }
    private void OnParticleCollision(GameObject other)
    {
        

        if (other.CompareTag("minigun"))
        {
            hp -= 40;
            if (hp <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
