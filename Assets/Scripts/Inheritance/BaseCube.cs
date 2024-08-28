using UnityEngine;

public class BaseCube : MonoBehaviour
{
    public Color cubeColor;

    private void Start() => GetComponent<Renderer>().material.color = cubeColor;
    
}
