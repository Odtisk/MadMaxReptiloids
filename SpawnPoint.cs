using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private DirectionPointer _directionPointer;

    private void Start()
    {
        _directionPointer = GetComponentInChildren<DirectionPointer>();
    }

    public Quaternion GetRotation()
    {
        return _directionPointer.transform.rotation;
    }
}
