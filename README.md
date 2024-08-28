# Unity Composition and Inheritance 

## Overview

This Unity project serves as a comprehensive example of **composition** and **inheritance** principles in object-oriented programming. The project includes scripts that demonstrate how these concepts can be effectively implemented to create flexible and maintainable code.

## Scripts

### Movement.cs

Handles player movement based on user input. The `Movement` script allows for basic directional movement using the arrow keys or WASD keys.

```csharp
using UnityEngine;

public class Movement : MonoBehaviour
{
    float speed = 5f;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
```

### Rotation.cs
Manages camera rotation based on mouse input. The `Rotation` script allows for controlling the camera's orientation using the mouse.

```csharp
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
```

### BaseCube.cs
Defines a base class for cubes with a customizable color. This script sets the color of the cube based on the `cubeColor` property.

```csharp
using UnityEngine;

public class BaseCube : MonoBehaviour
{
    public Color cubeColor;

    private void Awake() => GetComponent<Renderer>().material.color = cubeColor;
}
```

### BlueCube.cs
Inherits from `BaseCube` and sets the cube color to blue. This demonstrates the use of inheritance to create specific variants of a base class.

```csharp
using UnityEngine;

public class BlueCube : BaseCube
{
    private void Awake() => cubeColor = Color.blue;
}
```

### RedCube.cs
Inherits from `BaseCube` and sets the cube color to red. This shows how inheritance can be used to create different colored cubes while sharing common functionality.

```csharp
using UnityEngine;

public class RedCube : BaseCube
{
    private void Awake() => cubeColor = Color.red;
}
```
