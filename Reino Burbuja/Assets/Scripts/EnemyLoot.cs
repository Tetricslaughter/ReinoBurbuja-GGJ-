using UnityEngine;

public class EnemyLoot : MonoBehaviour
{
    public GameObject[] items;

    public void loot()
    {
        int randomIndex = Random.Range(0, items.Length);
        Instantiate(items[randomIndex], transform.position, Quaternion.identity);
    }

    void OnDestroy()
    {
        loot();
    }
}
