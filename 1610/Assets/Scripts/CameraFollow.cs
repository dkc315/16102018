using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	[SerializeField] private Vector3 offset;

	[SerializeField] private Transform targ;

	[SerializeField] private bool lookAt = true;

	private Space offsetPositionSpace = Space.Self;

	private void Update()
	{
		Refresh();
	}

	public void Refresh()
	{
		// compute position
		if (offsetPositionSpace == Space.Self)
		{
			transform.position = targ.TransformPoint(offset);
		}
		else
		{
			transform.position = targ.position + offset;
		}

		// compute rotation
		if (lookAt)
		{
			transform.LookAt(targ);
		}
		else
		{
			transform.rotation = targ.rotation;
		}
	}
}