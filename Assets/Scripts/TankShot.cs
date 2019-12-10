using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TankShot : MonoBehaviour
{
    public Tank tank;

    public SecondTank secondTank;

    public float speed = 50.0f;

    private Rigidbody2D rigidBody;

    public float tankHealth = 100.0f;

    public float secondTankHealth = 100.0f;

    public float damage = 25.0f;

    public Image healthBar;

    public Image secondHealthBar;

    public bool isTankAlive = true;

    public bool isSecondTankAlive = true;



    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

        rigidBody.velocity = transform.right * speed;


    }

    void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.tag == "SecondTank")
        {
            if (tank.GetIsMoving() == true)
            {
                Destroy(gameObject);

                TakeDamageTwo();


                if (secondTankHealth <= 0.0f)
                {
                    DestroyObject(col.gameObject);

                    isSecondTankAlive = false;

                    SceneManager.LoadScene("Winner");
                }
            }
           

        }
    
        if (col.tag == "Tank")
        {
            if (secondTank.GetIsMoving() == true)
            {

                Destroy(gameObject);


                TakeDamage();

                if (tankHealth <= 0.0f)
                {
                    DestroyObject(col.gameObject);

                    isTankAlive = false;

                    SceneManager.LoadScene("Winner");

                }

            }
        }
        
        
        if (col.tag == "Floor")
        {
            Destroy(gameObject);

        }
    }
    

    public void TakeDamage ()
    {
        tankHealth -= damage;

        healthBar.fillAmount = tankHealth / 100.0f;


    }

    public void TakeDamageTwo()
    {
        secondTankHealth -= damage;

        secondHealthBar.fillAmount = secondTankHealth / 100.0f;
    }

    public bool GetIsTankAlive()
    {
        return isTankAlive;
    }

    public bool GetIsSecondTankAlive()
    {
        return isSecondTankAlive;
    }



}
