using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectedObject : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    public int numberCoin = 1;
    public int rotateSpeed = 5;


    private void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, rotateSpeed * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("coin");
            gameManager.coinAd(numberCoin);
            Destroy(this.gameObject);
        }
    }
}
