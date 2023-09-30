using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] private float _cooldown = 2;

    private float _runningTime = 0;

    private void Update()
    {
        _runningTime += Time.deltaTime;

        if (_runningTime > _cooldown)
        {
            _runningTime = 0;
            var spawnPoint = GetRandomSpawnPoint();
            Spawn(spawnPoint);
        }
    }

    private void Spawn(SpawnPoint spawnPoint)
    {
        GameObject spawned = Instantiate(_gameObject);
        spawned.transform.position = spawnPoint.transform.position + transform.up;
        spawned.transform.rotation = spawnPoint.GetRotation();
    }

    private SpawnPoint GetRandomSpawnPoint()
    {
        int randomIndex = Random.Range(0, _spawnPoints.Length);
        return _spawnPoints[randomIndex];
    }
}
