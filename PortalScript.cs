using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public GameObject winScreen;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            PlayerController.isEnd = true;
            winScreen.SetActive(true);
            PlayerController.isWin = true;
            PlayerController.firstTime = false;
            GameObject.Find("Player").SetActive(false);
        }
    }
}
