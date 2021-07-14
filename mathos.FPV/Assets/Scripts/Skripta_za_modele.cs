using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skripta_za_modele : MonoBehaviour
{
    public float speed = 15f;
    void Update()
    {
        transform.Rotate(0,0, speed * Time.deltaTime);
    }
}
