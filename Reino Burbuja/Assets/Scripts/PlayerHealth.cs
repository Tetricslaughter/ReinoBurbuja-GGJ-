using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
   public int currentHp;
   public int maxhp;
     void Start()
    {
        currentHp = maxhp;
    }
    public void TakeDamage(int damage)
    {
        currentHp -= damage;
        Debug.Log($" Vida actual: {currentHp}");

        if (currentHp <= 0)
        {
            DestroyPlayer();
        }
    }
    void DestroyPlayer() 
    {
        Debug.Log("player destruido");
    }
}
