using UnityEngine;

public class CastleScript : MonoBehaviour
{
    public int currentHp;
    public int maxHp;
    public PantallaDerrota pantallaDerrota;
    private void Start()
    {

        currentHp = maxHp;
    }
    
    public void TakeDamage(int damage)
    {
        currentHp -= damage;
        Debug.Log($" Vida actual: {currentHp}");

        if (currentHp <= 0)
        {
            DestroyCastle();
        }
    }
    void DestroyCastle() 
    {
        Debug.Log("Castillo destruido");
        pantallaDerrota.CambiarDerrota(true);
    }
}
