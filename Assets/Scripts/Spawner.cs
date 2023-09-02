using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Player _player;
    [SerializeField] private float _seconds;

    private void Start()
    {
        StartCoroutine(CreateEnemy());
    }

    private IEnumerator CreateEnemy()
    {
        var waitForSeconds = new WaitForSeconds(_seconds);

        while (true)
        {
            Enemy enemy = Instantiate(_enemy, transform.position, Quaternion.identity);
            enemy.Init(_player);
            yield return waitForSeconds;
        }


    }
}
