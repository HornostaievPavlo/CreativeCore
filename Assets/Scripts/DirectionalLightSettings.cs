using UnityEngine;

public class DirectionalLightSettings : MonoBehaviour
{
    public Quaternion rotation;

    public bool isRotated;

    void FixedUpdate()
    {
        if (isRotated) transform.rotation *= rotation;
    }
}
