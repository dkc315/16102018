using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class StateMachine : ScriptableObject
{
	public GameStates.States GameState;

	public UnityEvent Starting, Loading, Playing, Pausing, Dying, Ending;
/*
	public Run {
		switch (GameState)
		{
		case GameStates.States.Starting:
		Starting.Invoke;
		break;

		case GameStates.States.Loading:
		Loading.Invoke();
		break;

		case GameStates.States.Playing:
		Playing.Invoke();
		break;

		case GameStates.States.Pausing:
		Pausing.Invoke();
		break;

		case GameStates.States.Dying:
		Dying.Invoke();
		break;

		case GameStates.States.Ending:
		Ending.Invoke();
		break;
		}
	}*/
}
