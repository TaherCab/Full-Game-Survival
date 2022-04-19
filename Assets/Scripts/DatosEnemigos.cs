using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosEnemigos : MonoBehaviour
{
    public int vidaEnemigos = 5;


    private void Update()
    {
        if(vidaEnemigos<= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
