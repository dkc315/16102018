using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchStatments : MonoBehaviour
{
	public GameStates.States GameState;
	public UnityEvent Starting, Loading, Playing, Pausing, Dying, Ending;
	
	void Update () {
		
		switch (GameState)
		{
			case GameStates.States.Starting:
				
				break;
			
			case GameStates.States.Loading:
				
				break;
			
			case GameStates.States.Playing:
				
				break;
			
			case GameStates.States.Pausing:
				
				break;
			
			case GameStates.States.Dying:
				
				break;
			
			case GameStates.States.Ending:
				
				break;
		}	
	}
}
