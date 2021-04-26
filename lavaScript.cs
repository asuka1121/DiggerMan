using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavaScript : MonoBehaviour
{
    public GameObject DeadScreen;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Player")
        {
            
            DeadScreen.SetActive(true);
            PlayerController.isEnd = true;
            GameObject.Find("Player").SetActive(false);
            Destroy(gameObject);
        }
    }
}
