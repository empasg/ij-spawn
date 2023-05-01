using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _spawnEnemy;

    public void Spawn()
    {
        Instantiate(_spawnEnemy, transform.position, Quaternion.identity);
    }
}
