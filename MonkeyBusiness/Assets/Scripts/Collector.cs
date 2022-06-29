using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "BG" || target.tag == "Extrapush" || target.tag == "Normalpush" || target.tag == "Enemy" || target.tag == "Platform")
        {
            target.gameObject.SetActive(false);
        }
    }
}