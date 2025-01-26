using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class MoveEnemy : MonoBehaviour
{
    NavMeshAgent agent;
    float speed;
    float detectionRange;
    bool  playerDetected;
    Collider[] colliders;
     Transform baseLocation;
    [SerializeField] LayerMask playerMask;
     Transform playerPosition;
    void Start()
    {
        baseLocation = GameObject.Find("Castillo").transform;
        playerPosition= GameObject.Find("Player").transform;
        detectionRange = 10f;
        speed = 5f;
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
        agent.SetDestination(baseLocation.position);
        playerDetected = false;
    }

    private void Stop()
    {
        agent.isStopped = true;   
    }
    private void Resume()
    {
        agent.isStopped = false;
        agent.SetDestination(baseLocation.position);
    }
    void Update()
    {
        CheckPlayer();
        if (playerDetected) 
        {
            agent.SetDestination(playerPosition.position);
        }
    }
    void CheckPlayer()
    {
        colliders = Physics.OverlapSphere(transform.position,detectionRange,playerMask);
     
        if (colliders.Length > 0) 
        {
            playerDetected = true;          
        }
        //Si contiene al menos 1 unidad debera atacar a esa.              
        

    }
}
