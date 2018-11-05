using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIInstancing : MonoBehaviour
{

	public GameObject Instance;
	public float FireRate;

	void Fire () {
		
		Instantiate(Instance, transform.position, transform.rotation);
		Wait();
	}

	private IEnumerator Wait ()
	{
		yield return new WaitForSeconds(FireRate);
		Fire();
	}
}
