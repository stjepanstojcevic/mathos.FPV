using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOver : MonoBehaviour
{
    public GameObject a;
    public void Start()
    {
        a.SetActive(false);
    }
    public void OnMouseOver()
    {
        a.SetActive(true);
    }
    public void OnMouseExit()
    {
        a.SetActive(false);
    }
}
