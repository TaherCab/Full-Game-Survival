using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    [SerializeField] GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerMovement>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {

     }

    private void OnTriggerStay (Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            Debug.Log ("esta Mirando");

            var direccion = (target.transform.position - transform.position).normalized;
            transform.position += direccion * speed * Time.deltaTime;

            transform.LookAt(target.transform);

        }
    }
}
