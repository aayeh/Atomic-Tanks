using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public float speed = 5;

    bool isMoving = true;

    void FixedUpdate()
    {
        float move = Input.GetAxisRaw("Horizontal");

        GetComponent<Rigidbody2D>().velocity = new Vector2(move, 0) * speed;

        if (isMoving == false)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(move, 0) * 0;
        }
    }

    public void ChangeIsMoving()
    {
        if (isMoving == true)
        {
            isMoving = false;
        }
        else if (isMoving == false)
        {
            isMoving = true;
        }
    }

    public bool GetIsMoving()
    {
        return isMoving;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }
}