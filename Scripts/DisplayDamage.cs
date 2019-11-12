using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Image impactCanvas;
    [SerializeField] float impactTime = 0.3f;

    public void ShowDamageImpact()
    {
        StartCoroutine(ShowSplatter());
    }

    IEnumerator ShowSplatter()
    {
        impactCanvas.gameObject.SetActive(true);
        yield return new WaitForSeconds(impactTime);
        impactCanvas.gameObject.SetActive(false);
    }

}
