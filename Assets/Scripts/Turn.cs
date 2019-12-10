using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turn : MonoBehaviour
{
    public Tank tank;

    public SecondTank secondTank;

    public Text turn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tank.GetIsMoving() == true)
        {
            turn.text = "Player One's Turn";
        }

        if (secondTank.GetIsMoving() == true)
        {
            turn.text = "Player Two's Turn";
        }
    }
}
