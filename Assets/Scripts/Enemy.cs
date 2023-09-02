using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Player _player;
    private bool _isPlaying => _player != null;

    private void Update()
    {
        if (_isPlaying)
        {
            transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, _speed * Time.deltaTime);
        }
    }

    public void Init(Player player)
    {
        _player = player;
    }

}
