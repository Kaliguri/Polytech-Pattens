using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewChase : MonoBehaviour, IMove
{
    public GameObject _hero;
    public float _speed;
    public float _distanceForSwap;

    private float distance;
    public void Move(GameObject hero, float speed) {
        transform.position = Vector3.MoveTowards(transform.position, hero.transform.position, speed);
    }

    void FixedUpdate()
    {
        distance = (transform.position - _hero.transform.position).magnitude;
        if (distance > _distanceForSwap) { Move(_hero, _speed); }
    }
}
