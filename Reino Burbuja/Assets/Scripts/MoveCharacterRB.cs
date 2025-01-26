using UnityEngine;
using UnityEngine.EventSystems;

public class MoveCharacterRB : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    float vertical, horizontal;
    Vector3 moveDirection;
    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
       moveDirection = new Vector3(horizontal,0,vertical).normalized;
        
    }
    void FixedUpdate()
    {
        Vector3 velocity = moveDirection * speed;
        rb.linearVelocity = new Vector3(velocity.x,rb.linearVelocity.y,velocity.z);
    }
}
