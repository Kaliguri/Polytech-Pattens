using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ArcherStrategy : MonoBehaviour
{
    private GameObject _hero => GameObject.FindWithTag("Hero");

    public float _speed;
    public float _distanceForSwap;

    private float distance;

    void FixedUpdate()
    {
        distance = (transform.position - _hero.transform.position).magnitude;

        if (distance > _distanceForSwap) { Chase.Move(transform,_hero, _speed); }

        else { Retreat.Move(transform, _hero, _speed);}
        
    }
}
