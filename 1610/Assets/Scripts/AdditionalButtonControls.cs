using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class AdditionalButtonControls : MonoBehaviour
{
    public Canvas PauseMenu;
    private Instancing playerWeapon;
    private CharacterMover playerMover;
    private bool paused;

    private void Start()
    {
        playerWeapon = GetComponentInChildren<Instancing>();
        playerMover = GetComponent<CharacterMover>();
        PauseMenu.enabled = false;
        paused = false;

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
                StopCoroutine(PauseMenuStop());
                PauseMenu.enabled = true;
                playerWeapon.enabled = false;
                playerMover.enabled = false;
                paused = true;
                print("Ran");
                yield return new WaitForSeconds(1);
                StartCoroutine(PauseMenuStop());
            }
            yield return null;
        }
    }
    
    IEnumerator PauseMenuStop()
    {
        while (true)
         {
             if (paused && Input.GetKey(KeyCode.Escape))
                {
                    StopCoroutine(PauseMenuStart());
                    PauseMenu.enabled = false;
                    playerWeapon.enabled = true;
                    playerMover.enabled = true;
                    paused = false;
                    print("Ran2");
                    yield return new WaitForSeconds(1);
                    StartCoroutine(PauseMenuStart());
                }
             yield return null;
         }
    }
}
