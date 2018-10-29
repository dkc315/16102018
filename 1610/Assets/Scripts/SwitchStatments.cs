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
				//Invoke(Starting);
				break;
			
			case GameStates.States.Loading:
				//Invoke(Loading);
				break;
			
			case GameStates.States.Playing:
				//Invoke(Playing);
				break;
			
			case GameStates.States.Pausing:
				//Invoke(Pausing);
				break;
			
			case GameStates.States.Dying:
				//Invoke(Dying);
				break;
			
			case GameStates.States.Ending:
				//Invoke(Ending);
				break;
		}	
	}
}
