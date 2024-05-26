using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retreat : MonoBehaviour, IMove
{
    static public void Move(Transform position, GameObject hero, float speed)
    {
        position.position = Vector3.MoveTowards(position.position, hero.transform.position, -speed);
    }
}
