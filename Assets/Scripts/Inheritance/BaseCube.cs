using UnityEngine;

public class BaseCube : MonoBehaviour
{
    public Color cubeColor;

    private void Awake() => GetComponent<Renderer>().material.color = cubeColor;
    
}
