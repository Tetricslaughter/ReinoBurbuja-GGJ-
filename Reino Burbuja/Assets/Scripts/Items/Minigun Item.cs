using Unity.Mathematics;
using UnityEngine;

public class MinigunItem : MonoBehaviour
{
    GameObject player;
    GameObject minigun;
    GameObject pistol;
    GameObject shotgun;
    Minigun minigunScript;
    GameObject minigunModel;
    GameObject pistolModel;
    GameObject shotgunModel;

    [SerializeField] GameObject minigunPrefab;
    private void Start()
    {
        player = GameObject.Find("Player");
        minigunScript= player.GetComponent<Minigun>();
        pistol =   player.transform.GetChild(5).gameObject;
        shotgun=   player.transform.GetChild(6).gameObject;
        minigun=  player.transform.GetChild(7).gameObject;
        pistolModel = player.transform.GetChild(4).gameObject;
        shotgunModel = player.transform.GetChild(9).gameObject;
        minigunModel = player.transform.GetChild(8).gameObject;




    }
    
    void Update()
    {
        Destroy(this.gameObject, 4f);
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

                pistolModel.SetActive(false);
                shotgunModel.SetActive(false);
                minigunModel.SetActive(true);
            }
            Destroy(this.gameObject);
        }
    }
}
