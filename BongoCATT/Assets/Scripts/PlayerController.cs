using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed = 1f;

    public bool input_Right = false;
    public bool input_Left = false;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

   
    public void Move()
    {
        Vector3 movePosition = Vector3.zero;

        if(input_Right)
        {
            movePosition = Vector3.right;
            GetComponent<SpriteRenderer>().flipX = false;
            
        }

       

        transform.position += movePosition * moveSpeed * Time.deltaTime;

    }

   



    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Arrival_Point"))
        {
            SceneManager.LoadScene("GameEnding");
        }

        if (other.CompareTag("Rock"))
        {
            transform.position = other.transform.position - other.transform.right * 15f;

        }

    }



}