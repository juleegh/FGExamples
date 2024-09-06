using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiggyBank : MonoBehaviour
{
    private int tenCentCoins;
    private int twentyFiveCentCoins;
    private int fiftyCentCoins;
    private int oneDollarBills;
    private int fiveDollarBills;
    private float totalMoney;

    // --------- FUNCTIONS ----------

    public void Add10()
    {
        tenCentCoins = tenCentCoins + 1;
        totalMoney = totalMoney + 0.1f;
    }

    public void Add25()
    {
        twentyFiveCentCoins = twentyFiveCentCoins + 1;
        totalMoney = totalMoney + 0.25f;
    }

    public void Add50()
    {
        fiftyCentCoins = fiftyCentCoins + 1;
        totalMoney = totalMoney + 0.5f;
    }

    public void DoAction1()
    {
        oneDollarBills = oneDollarBills + 1;
        totalMoney = totalMoney + 1f;
    }

    public void DoAction2()
    {
        fiveDollarBills = fiveDollarBills + 1;
        totalMoney = totalMoney + 5f;
    }

    public string GetText1()
    {
        return "This is the button 1.";
    }

    public string GetText2()
    {
        return "This is the button 2.";
    }

    public string GetText3()
    {
        return "This is the button 3.";
    }

    public string GetText4()
    {
        return "The total amount of money in the pig is " + totalMoney;
    }
}
