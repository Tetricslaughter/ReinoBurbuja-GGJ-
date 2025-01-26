using Unity.Mathematics;
using UnityEngine;

public class MinigunItem : MonoBehaviour
{


    GameObject player;
    GameObject minigun;
    GameObject pistol;
    GameObject shotgun;
    Minigun minigunScript;
    [SerializeField] GameObject minigunPrefab;
    private void Start()
    {
        player = GameObject.Find("Player");
        minigunScript= player.GetComponent<Minigun>();
        pistol =   player.transform.GetChild(5).gameObject;
        shotgun=   player.transform.GetChild(6).gameObject;
        minigun=  player.transform.GetChild(7).gameObject;

              


    }
    
    void Update()
    {
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (minigun.activeInHierarchy)
            {
                minigunScript.timeCount = 0;
            }
            else
            {
                
                pistol.SetActive(false); 
                shotgun.SetActive(false);
                minigunScript.timeCount = 0;
                minigun.SetActive(true);
            }
            Destroy(this.gameObject);
        }
    }
}
