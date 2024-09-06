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

    // --------- FUNCTIONS ----------

    public float GetTotalMoney()
    {
        return tenCentCoins * 0.1f + twentyFiveCentCoins * 0.25f + fiftyCentCoins * 0.5f + oneDollarBills * 1f + fiveDollarBills * 5f;
    }

    public void ApplyGrandmasGift()
    {
        tenCentCoins = tenCentCoins * 2;
        twentyFiveCentCoins = twentyFiveCentCoins * 2;
        fiftyCentCoins = fiftyCentCoins * 2;
        oneDollarBills = oneDollarBills * 2;
        fiveDollarBills = fiveDollarBills * 2;
    }

    public void Add10()
    {
        tenCentCoins = tenCentCoins + 1;
    }

    public void Add25()
    {
        twentyFiveCentCoins = twentyFiveCentCoins + 1;
    }

    public void Add50()
    {
        fiftyCentCoins = fiftyCentCoins + 1;
    }

    public void DoAction1()
    {
        oneDollarBills = oneDollarBills + 1;
    }

    public void DoAction2()
    {
        fiveDollarBills = fiveDollarBills + 1;
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
        ApplyGrandmasGift();
        return "The total amount of money after grandmas gift is " + GetTotalMoney();
    }
}
