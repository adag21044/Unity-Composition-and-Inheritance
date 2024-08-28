using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float sensitivity = 10f;

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        
        transform.Rotate(Vector3.up * mouseX);

        
        transform.Rotate(Vector3.left * mouseY);
    }
}
