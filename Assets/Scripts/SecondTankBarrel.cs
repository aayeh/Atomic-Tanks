using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondTankBarrel : MonoBehaviour
{
    public SecondTank secondTank;

    public GameObject TankShot;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (secondTank.GetIsMoving() == true)
        {
            if (Input.GetButtonDown("Jump"))
            {

                // Create a TankShot at transform.position which
                // is the ships current location
                // Quaternion.identity adds Bullet with no rotation
                Instantiate(TankShot, transform.position, Quaternion.identity);

            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                RotateUp();
            }
            

            if (Input.GetKey(KeyCode.DownArrow))
            {
                RotateDown();
            }
           
        }

    }

    void RotateDown()
    {
        transform.Rotate(new Vector3(0, 0, 90) * 2f * Time.deltaTime);
    }

    void RotateUp()
    {
        transform.Rotate(new Vector3(0, 0, 90) * -2f * Time.deltaTime);
    }
}
