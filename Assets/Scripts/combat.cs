using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combat : MonoBehaviour
{
   
	Animator anim2;

	void Start()
	{
		anim2 = GetComponent<Animator>();
	}

	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			anim2.SetTrigger("Attack");
		}

	}
}