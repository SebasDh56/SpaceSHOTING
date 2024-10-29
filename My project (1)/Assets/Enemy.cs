using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f; 
    public float moveDistance = 5f; 

    private Vector3 startPosition;
    private bool movingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (movingRight)
        {
            
            transform.position += Vector3.right * speed * Time.deltaTime;

            
            if (transform.position.x >= startPosition.x + moveDistance)
            {
                movingRight = false;
            }
        }
        else
        {
            
            transform.position += Vector3.left * speed * Time.deltaTime;

            
            if (transform.position.x <= startPosition.x - moveDistance)
            {
                movingRight = true;
            }
        }
    }
}
