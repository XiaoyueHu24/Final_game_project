using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CreditToBoard : MonoBehaviour
{
    public Text CreditText;

    private float Time;
    private int Coin;
    private int Credit;

    void Start()
    {
        updateCredit();
    }

    void updateCredit()
    {
        Time = Timer.returnTime();
        Coin = pointscounter.count;
        Credit = Mathf.FloorToInt(Time) * 2 + Coin * 5;

        float minutes = Mathf.FloorToInt(Time / 60);
        float seconds = Mathf.FloorToInt(Time % 60);

        CreditText.text = "Remain Time: " + string.Format("{0:00}:{1:00}", minutes, seconds)
                        + "\nCollected Coins: " + string.Format("{0}", Coin)
                        + "\nCredit (Time*2 + Coins*5): " + string.Format("{0}", Credit);
    }
}
