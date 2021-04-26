using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScript : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "Player")
        {
            PlayerController.Star += 1;
            Destroy(gameObject);
            other.gameObject.transform.position = new Vector2(Mathf.RoundToInt(other.gameObject.transform.position.x),other.gameObject.transform.position.y);
            FindObjectOfType<AudioManager>().Play("CoinPickUp");
        }
        
    }
}
