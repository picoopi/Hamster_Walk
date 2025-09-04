using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{

    GameObject player;

    void Start()
    {
        this.player = GameObject.Find("Player");
    }


    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(playerPos.x, transform.position.y, transform.position.z); 
    }
}
