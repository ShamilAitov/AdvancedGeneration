using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Player _target;
    private bool HasTarget => _target != null;

    private void Update()
    {
        if (HasTarget)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);
        }
    }

    public void SetTarget(Player player)
    {
        _target = player;
    }

}
