using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Player _target;
    private bool GoalReceived => _target != null;

    private void Update()
    {
        if (GoalReceived)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);
        }
    }

    public void Init(Player player)
    {
        _target = player;
    }

}
