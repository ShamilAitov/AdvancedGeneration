using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Player _player;
    [SerializeField] private float _waitingTime;

    private void Start()
    {
        StartCoroutine(CreateEnemy());
    }

    private IEnumerator CreateEnemy()
    {
        var waitForSeconds = new WaitForSeconds(_waitingTime);

        while (true)
        {
            Enemy enemy = Instantiate(_enemy, transform.position, Quaternion.identity);
            enemy.SetTarget(_player);
            yield return waitForSeconds;
        }


    }
}
