using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Winner : MonoBehaviour
{
    public TankShot tank;

    public Text winner;

    public string winnerText = "The Winner is: ";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tank.GetIsTankAlive() == false)
        {
            winner.text = winnerText + "Player Two!";
        }
        if (tank.GetIsSecondTankAlive() == false)
        {
            winner.text = winnerText + "Player One!";
        }
    }
}
