using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 20;
    public GameObject explosion;
    public MeshRenderer meshRenderer;
    //private void OnCollisionStay(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        Debug.Log("choque con player");
    //        collision.gameObject.GetComponent<PlayerHealth>()?.TakeDamage(damage);
    //    }
    //    if (collision.gameObject.CompareTag("Castle"))
    //    {
    //        collision.gameObject.GetComponent<CastleScript>()?.TakeDamage(damage);
    //    }
    //}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("choque con player");
            collision.gameObject.GetComponent<PlayerHealth>()?.TakeDamage(damage);
        }
        if (collision.gameObject.CompareTag("Castle"))
        {
            Debug.Log("inshalah");
            collision.gameObject.GetComponent<CastleScript>()?.TakeDamage(damage);
            meshRenderer.enabled = false;
            Instantiate(explosion,transform.position,transform.rotation);
            
            Destroy(this.gameObject,1f);
        }
    }
}
