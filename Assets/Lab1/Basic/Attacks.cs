using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacks : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) { Sword.Attack(); }
        if (Input.GetKeyDown(KeyCode.W)) { Bow.Attack(); }
        if (Input.GetKeyDown(KeyCode.E)) { Magic.Attack(); }

    }

}
