using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameHandler : MonoBehaviour
{
    float timeRunning = 10.0f;
    public Tank tank;
    public SecondTank secondTank;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeRunning -= Time.deltaTime;

        if (timeRunning <= 0.0f)
        {
            tank.ChangeIsMoving();
            secondTank.ChangeIsMoving();

            timeRunning = 10;

        }

        if (Input.GetButtonDown("Jump"))
        {
            timeRunning = 10;

            tank.ChangeIsMoving();
            secondTank.ChangeIsMoving();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Pause");
        }
    }
}
