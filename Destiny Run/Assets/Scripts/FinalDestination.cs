using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinalDestination : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject levelCompletedPanel;
    // public Animator animation;

    public TextMeshProUGUI txt1;
    private void Start()
    {
        levelCompletedPanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            txt1.text = "You win";
            StartCoroutine(finishLevel());
            // animation.SetBool("idel", true);
        }
    }

    IEnumerator finishLevel()
    {
        yield return new WaitForSeconds(1f);
        levelCompletedPanel.SetActive(true);

    }
}
