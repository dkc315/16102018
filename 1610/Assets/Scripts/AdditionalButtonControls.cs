using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class AdditionalButtonControls : MonoBehaviour
{
    public Canvas PauseMenu;
    private Instancing playerWeapon;
    private CharacterMover playerMover;

    private void Start()
    {
        playerWeapon = GetComponentInChildren<Instancing>();
        playerMover = GetComponent<CharacterMover>();
        PauseMenu.enabled = false;

        StartCoroutine(PauseMenuStart());
    }

    private void Update()
    {
       
    }

    IEnumerator PauseMenuStart()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                PauseMenu.enabled = true;
                playerWeapon.PauseToggle = true;
                playerMover.enabled = false;
                yield return new WaitForSeconds(2);
                StartCoroutine(PauseMenuStop());
            }
            yield return null;
        }
    }

    IEnumerator PauseMenuStop()
    {
        while (true)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                PauseMenu.enabled = false;
                playerWeapon.PauseToggle = false;
                playerMover.enabled = true;
                StopCoroutine(PauseMenuStop());
            }
            yield return null;
        }
    }
}
