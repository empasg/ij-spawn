using System.Collections;
using UnityEngine;

public class EnemySpawnControl : MonoBehaviour
{
    [SerializeField] private float _spawnTime;
    private EnemySpawner[] _enemySpawners;
    private bool _isSpawning;

    private void Awake()
    {
        _enemySpawners = GetComponentsInChildren<EnemySpawner>();
        _isSpawning = true;
    }

    private void Start()
    {
        StartCoroutine(SpawnInOrder());
    }

    private IEnumerator SpawnInOrder()
    {
        var delay = new WaitForSeconds(_spawnTime);

        while (_isSpawning)
        {
            foreach (EnemySpawner enemySpawner in _enemySpawners)
            {
                enemySpawner.Spawn();

                yield return delay;
            }
        }
    }
}
