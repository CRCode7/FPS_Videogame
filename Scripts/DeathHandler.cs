using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class DeathHandler : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;

    private void Start()
    {
        gameOverCanvas.gameObject.SetActive(false);
    }

    public void HandleDeath()
    {
        gameOverCanvas.gameObject.SetActive(true);

        
        FindObjectOfType<WeaponSwitcher>().enabled = false;
        FindObjectOfType<RigidbodyFirstPersonController>().enabled = false;

         Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

}
