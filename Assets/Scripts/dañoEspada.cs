using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dañoEspada : MonoBehaviour
{

    [SerializeField]
    private int daño;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            other.GetComponent<DatosEnemigos>().vidaEnemigos -= daño;

        }
    }

}

