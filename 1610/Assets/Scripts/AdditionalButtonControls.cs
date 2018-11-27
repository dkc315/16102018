using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class AdditionalButtonControls : MonoBehaviour
{
    public Canvas PauseMenu;
    private Instancing playerWeapon;
    private CharacterMover playerMover;
    public bool Paused;

    private void Start()
    {
        playerWeapon = GetComponentInChildren<Instancing>();
        playerMover = GetComponent<CharacterMover>();
        PauseMenu.enabled = false;
        Paused = false;

        StartCoroutine(PauseMenuStart());
        StartCoroutine(PauseMenuStop());
    }

    private void Update()
    {
       
    }

    IEnumerator PauseMenuStart()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.Escape) && !Paused)
            {
                PauseMenu.enabled = true;
                playerWeapon.PauseToggle = true;
                playerMover.enabled = false;
                yield return new WaitForSeconds(0.2f);
                Paused = true;
                print("1");
            }
            
            yield return null;
        }
    }

    IEnumerator PauseMenuStop()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.Escape) && Paused)
            {
                PauseMenu.enabled = false;
                playerWeapon.PauseToggle = false;
                playerMover.enabled = true;
                yield return new WaitForSeconds(0.2f);
                Paused = false;
                print("2");
            }
            yield return null;
        }
    }
}
