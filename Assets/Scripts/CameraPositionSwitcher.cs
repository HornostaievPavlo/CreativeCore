using UnityEngine;

public class CameraPositionSwitcher : MonoBehaviour
{
    public Transform[] positions;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            for (int i = 0; i < positions.Length; i++)
            {
                ChangePosition(i);
            }
        }
    }

    void ChangePosition(int indexOfPosition)
    {
        transform.position = positions[indexOfPosition].transform.position;
        transform.rotation = positions[indexOfPosition].transform.rotation;
    }
}
