using UnityEngine;

public class BouncingObject : MonoBehaviour
{
    public AnimationCurve animCurve;

    Vector3 startingPos;

    void Start()
    {
        startingPos = transform.position;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, startingPos.y + animCurve.Evaluate((Time.time % animCurve.length)), transform.position.z);
    }
}
