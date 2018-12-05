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
			yield return new WaitForSeconds(FireRate);
			Instantiate(Instance, transform.position, transform.rotation);

		}
	
	}
}
