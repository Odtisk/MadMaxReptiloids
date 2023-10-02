using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private SpawnPoint[] _spawnPoints;
    [SerializeField] private float _cooldown = 2;
    [SerializeField] private bool _shouldSpawn = true;

    private void Start()
    {
        StartCoroutine(Work());
    }

    private IEnumerator Work()
    {
        var waitingTime = new WaitForSeconds(_cooldown);

        while (_shouldSpawn)
        {
            var spawnPoint = GetRandomSpawnPoint();
            Spawn(spawnPoint);
            yield return waitingTime;
        }
    }

    private void Spawn(SpawnPoint spawnPoint)
    {
        GameObject spawned = Instantiate(_gameObject);
        spawned.transform.SetPositionAndRotation(spawnPoint.GetPosition(), spawnPoint.GetRotation());
    }

    private SpawnPoint GetRandomSpawnPoint()
    {
        int randomIndex = Random.Range(0, _spawnPoints.Length);
        return _spawnPoints[randomIndex];
    }
}
