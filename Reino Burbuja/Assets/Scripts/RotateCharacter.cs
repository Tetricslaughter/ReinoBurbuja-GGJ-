using UnityEngine;

public class RotateCharacter : MonoBehaviour
{
    private void Update()
    {
        Vector3 objective = MousePosition();
        objective.y = transform.position.y;
        transform.LookAt(objective);
    }

    public static Vector3 MousePosition()
    {
        Vector3 mousePos = new Vector3(0, 0, 0);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit raycastHit;
        if (Physics.Raycast(ray, out raycastHit))
        {
            mousePos = raycastHit.point;
            return mousePos;
        }
        return mousePos;
    }

}
