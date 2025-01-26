using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class MoveCharacter : MonoBehaviour
{
    CharacterController controller;
    float horizontal;
    float vertical;
    float speed;
    void Start()
    {
        speed =200f;
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        controller.SimpleMove(new Vector3(horizontal, 0, vertical) *Time.deltaTime * speed);
        
    }
}
