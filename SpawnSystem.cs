using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    [SerializeField] private Spawner[] _spawners;
    [SerializeField] private float _cooldown = 2;

    private float _runningTime = 0;

    private void Update()
    {
        _runningTime += Time.deltaTime;

        if (_runningTime > _cooldown)
        {
            _runningTime = 0;
            var spawner = _spawners[Random.Range(0, _spawners.Length)];
            spawner.Spawn();
        }
    }
}
