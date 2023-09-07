using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiggyBank : MonoBehaviour
{
    // --------- ATTRIBUTES ----------

    private int tenCentCoins;
    
    private int twentyFiveCentCoins;
    
    private int fiftyCentCoins;

    [SerializeField] private float tax = 0.03f;

    [SerializeField] private Cheque cheque1;
    [SerializeField] private Cheque cheque2;

    // --------- FUNCTIONS ----------

    public void Add10()
    {
        tenCentCoins++;
    }

    public void Add25()
    {
        twentyFiveCentCoins++;
    }

    public void Add50()
    {
        fiftyCentCoins++;
    }

    private float GetTotalMoney()
    {
        return tenCentCoins * 0.1f + twentyFiveCentCoins * 0.25f + fiftyCentCoins * 0.5f;
    }

    private float GetTotalMoneyAfterTaxes()
    {
        return GetTotalMoney() * (1 - tax);
    }

    private void IncreaseTax()
    {
        tax += 0.03f;
    }

    public void DoAction1()
    {
        IncreaseTax();
    }

    public void DoAction2()
    {

    }

    public string GetText1()
    {
        return "The total money in the piggy right now is $" + GetTotalMoney();
    }

    public string GetText2()
    {
        return "The total money in the piggy after taxes is $" + GetTotalMoneyAfterTaxes();
    }

    public string GetText3()
    {
        return "The issuers of the cheques are: " + cheque1.GetIssuedBy() + ", " + cheque2.GetIssuedBy();
    }

    public string GetText4()
    {
        return "This is the button 4.";
    }
}
