using UnityEngine;

public class ShotgunItem : MonoBehaviour
{
    GameObject player;
    GameObject minigun;
    GameObject pistol;
    GameObject shotgun;
    Shotgun shotgunScript;

    private void Start()
    {
        player = GameObject.Find("Player");
        shotgunScript = player.GetComponent<Shotgun>();
        pistol = player.transform.GetChild(5).gameObject;
        shotgun = player.transform.GetChild(6).gameObject;
        minigun = player.transform.GetChild(7).gameObject;




    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (minigun.activeInHierarchy)
            {
                shotgunScript.cont = 0;
            }
            else
            {

                pistol.SetActive(false);
                minigun.SetActive(false);
                shotgun.SetActive(true);
                shotgunScript.cont = 0;
                
            }
            Destroy(this.gameObject);
        }
    }
}
