
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            Destroy(gameObject);
        }
    }

   
}
