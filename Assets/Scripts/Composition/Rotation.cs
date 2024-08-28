using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float sensitivity = 10f;

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Y ekseninde döndürme (yatay eksen)
        transform.Rotate(Vector3.up * mouseX);

        // X ekseninde döndürme (dikey eksen)
        // Burada X ekseninde döndürme işlemi y eksenindeki sınırlamalara göre yapılabilir
        transform.Rotate(Vector3.left * mouseY);
    }
}
