using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    float whereDig;
    public GameObject arrowUp;
    public GameObject arrowDown;
    public GameObject arrowLeft;
    public GameObject arrowRight;
    void Start()
    {
        Physics2D.queriesStartInColliders = false;
    }

    // Update is called once per frame
    void Update()
    {
        int layerMask = 1 << 2;
        layerMask = ~layerMask;
        RaycastHit2D hitInfo = Physics2D.Raycast (transform.position, transform.up*-1, 1f,layerMask);
        RaycastHit2D hitInfoUp = Physics2D.Raycast (transform.position, transform.up, 1f,layerMask);
        RaycastHit2D hitInfoRight = Physics2D.Raycast (transform.position, transform.right*-1,1f,layerMask);
        RaycastHit2D hitInfoLeft = Physics2D.Raycast (transform.position, transform.right,1f, layerMask);

        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var direction = worldPosition - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.x , direction.y)*180/Mathf.PI;
        

        if(angle > 45 && angle < 135)
        {
            whereDig = 2;
        }
        else if(angle > 135 && angle < 180)
        {
            whereDig = 3;
        }
        else if(angle < -135 && angle > -180)
        {
            whereDig = 3;
        }
        else if(angle < -45 && angle > -135)
        {
            whereDig = 1;
        }
        else 
        {
            whereDig = 0;
        }
        if(whereDig == 0)
        {
            arrowUp.SetActive(true);
            arrowLeft.SetActive(false);
            arrowRight.SetActive(false);
            arrowDown.SetActive(false);
        }
        else if(whereDig == 1)
        {
            arrowUp.SetActive(false);
            arrowLeft.SetActive(true);
            arrowRight.SetActive(false);
            arrowDown.SetActive(false);
        }
        else if(whereDig == 2)
        {
            arrowUp.SetActive(false);
            arrowLeft.SetActive(false);
            arrowRight.SetActive(true);
            arrowDown.SetActive(false);
        }
        else if(whereDig == 3)
        {
            arrowUp.SetActive(false);
            arrowLeft.SetActive(false);
            arrowRight.SetActive(false);    
            arrowDown.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(whereDig == 0)
            {
                
                if(hitInfoUp.collider != null)
                {
                    if(hitInfoUp.collider.tag != "Border" && hitInfoUp.collider.tag!= "Unbreakable")
                    {
                        FindObjectOfType<AudioManager>().Play("Dig");
                        Destroy(hitInfoUp.collider.gameObject);
                    }
                }
            }
            if(whereDig == 1)
            {
                if(hitInfoRight.collider != null)
                {
                    if(hitInfoRight.collider.tag != "Border"&& hitInfoRight.collider.tag!= "Unbreakable")
                    {
                        FindObjectOfType<AudioManager>().Play("Dig");
                        Destroy(hitInfoRight.collider.gameObject);
                    }
                }
            }
            if(whereDig == 2)
            {
                if(hitInfoLeft.collider != null)
                {
                    if(hitInfoLeft.collider.tag != "Border"&& hitInfoLeft.collider.tag!= "Unbreakable")
                    {
                        FindObjectOfType<AudioManager>().Play("Dig");
                        Destroy(hitInfoLeft.collider.gameObject);
                    }
                }
            }
            if(whereDig == 3)
            {
                if(hitInfo.collider != null)
                {
                    if(hitInfo.collider.tag != "Border"&& hitInfo.collider.tag!= "Unbreakable")
                    {
                        FindObjectOfType<AudioManager>().Play("Dig");
                        Destroy(hitInfo.collider.gameObject);
                    }
                }
            }
        }
    }
}
