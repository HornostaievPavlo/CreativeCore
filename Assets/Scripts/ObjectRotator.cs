using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    public Quaternion rotation;

    public bool isRotated;

    void FixedUpdate()
    {
        if (isRotated) transform.rotation *= rotation;
    }
}
