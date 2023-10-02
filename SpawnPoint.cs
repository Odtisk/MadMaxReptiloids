using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private DirectionPointer _directionPointer;

    private void Awake()
    {
        _directionPointer = GetComponentInChildren<DirectionPointer>();
    }

    public Quaternion GetRotation()
    {
        return _directionPointer.transform.rotation;
    }

    public Vector3 GetPosition()
    {
        return transform.position + transform.up;
    }
}
