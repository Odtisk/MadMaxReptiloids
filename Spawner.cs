using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;

    private DirectionPointer _directionPointer;

    private void Start()
    {
        _directionPointer = GetComponentInChildren<DirectionPointer>();
    }

    public void Spawn()
    {
        GameObject spawned = Instantiate(_gameObject);
        spawned.transform.position = transform.position + transform.up;
        spawned.transform.rotation = _directionPointer.transform.rotation;
    }
}
