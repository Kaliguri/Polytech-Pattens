using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherMovement : MonoBehaviour
{
    [SerializeField] GameObject _hero;
    [SerializeField] float _speed;
    [SerializeField] float _distanceForSwap;

    private float distance;

    // Update is called once per frame
    void FixedUpdate()
    {
        distance = (transform.position - _hero.transform.position).magnitude;
        if (distance >= _distanceForSwap) { }
        else { }


    }
}
