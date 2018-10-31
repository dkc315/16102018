using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMovement : MonoBehaviour
{

    public GameObject Player;
    public CharacterMover Mover;
    public float SlowAmount, InitialSpeed;
    
    private void OnTriggerEnter(Collider other)
    {
        Mover = Player.GetComponent<CharacterMover>();
        InitialSpeed = Mover.MoveSpeed;
        Mover.MoveSpeed /= SlowAmount;
    }

    private void OnTriggerExit(Collider other)
    {
        Mover.MoveSpeed = InitialSpeed;
    }
}
