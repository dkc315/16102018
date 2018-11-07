using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIInstancing : MonoBehaviour
{

	public GameObject Instance;
	public float FireRate;

	private IEnumerator Start()
	{
		for (;;)
		{
			Instantiate(Instance, transform.position, transform.rotation);
            yield return new WaitForSeconds(FireRate);
		}
	
	}
}
