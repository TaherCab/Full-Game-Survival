using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyDamage : MonoBehaviour
{
    
    public Slider vidaPlayer;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("colicion");
            vidaPlayer.value -= 1;
            
        }

    }

   

    private void Update()
    {
        Debug.Log(vidaPlayer.value);

        if (Vector3.Distance(transform.position, Player.transform.position) > 12 )
        {
            
        }
        else
        {

            transform.LookAt(Player.transform);
            
            transform.position += transform.forward * 1 * Time.deltaTime;

            
        }


    }

    private void Start()
    {
        Player = FindObjectOfType<PlayerMovement>().gameObject;
        vidaPlayer.value = 10;
        
    }

  
}
