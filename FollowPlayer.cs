using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    
    void Update()
    {
        Vector3 pos = new Vector3(player.transform.position.x , player.transform.position.y, -10f);
        transform.position = pos;
    }
}
