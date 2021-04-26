using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject DeadScreen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int layerMask = 1 << 2;
        layerMask = ~layerMask;
        RaycastHit2D hitInfoUp = Physics2D.Raycast (transform.position, transform.up, 10,layerMask);
        RaycastHit2D hitInfoDown = Physics2D.Raycast (transform.position, transform.up*-1, 10,layerMask);
        RaycastHit2D hitInfoLeft = Physics2D.Raycast (transform.position, transform.right*-1,10,layerMask);
        RaycastHit2D hitInfoRight = Physics2D.Raycast (transform.position, transform.right,10, layerMask);
        if(hitInfoUp.collider != null)
        {
            if(hitInfoUp.collider.gameObject.name == "Player")
            {
                DeadScreen.SetActive(true);
                PlayerController.isEnd = true;
            }
        }
        if(hitInfoDown.collider != null)
        {
            if(hitInfoDown.collider.gameObject.name == "Player")
            {
                DeadScreen.SetActive(true);
                PlayerController.isEnd = true;
            }
        }
        if(hitInfoLeft.collider != null)
        {
            if(hitInfoLeft.collider.gameObject.name == "Player")
            {
                DeadScreen.SetActive(true);
                PlayerController.isEnd = true;
            }
        }
        if(hitInfoRight.collider != null)
        {
            if(hitInfoRight.collider.gameObject.name == "Player")
            {
                DeadScreen.SetActive(true);
                PlayerController.isEnd = true;
                GameObject.Find("Player").SetActive(false);
            }
        }
        
    }
}
