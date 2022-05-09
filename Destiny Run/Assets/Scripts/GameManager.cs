using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int coin = 1;
    public TextMeshProUGUI txt1;

    public void coinAd(int x)
    {
        coin += x;
        //collectedPlayerCount += x;
    }

    private void Update()
    {
        txt1.text = "Total : " + coin;
    }

    public void retry()
    {
        SceneManager.LoadScene("Game");
    }
}
