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

    [SerializeField] private float bikePrice = 100;
    [SerializeField] private float ps5Price = 500;
    [SerializeField] private float pokemonPlushiePrice = 20;

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

    private bool CanAffordThisPresent(float price)
    {
        return GetTotalMoneyAfterTaxes() >= price;
    }

    private bool CanIAffordChristmasPresent()
    {
        if (CanAffordThisPresent(bikePrice) || CanAffordThisPresent(ps5Price) || CanAffordThisPresent(pokemonPlushiePrice))
        {
            return true;
        }

        // if the previous if is not excecuted then the function wouldnt return anything
        // and the compiler wouldnt like that
        // so in this case we add this
        return false;
        // which is what should be returned in case we cannot afford anything, problem solved!

        // Alternatively, we could just return whats done inside the if, like so:
        // return CanAffordPresent(bikePrice) || CanAffordPresent(ps5Price) || CanAffordPresent(pokemonPlushiePrice);
    }

    private string MostExpensivePresentICanPay()
    {
        // First we validate if the PS5 is the most expensive gift
        if (ps5Price >= bikePrice && ps5Price >= pokemonPlushiePrice)
        {
            // Then we check if we can afford it
            if (CanAffordThisPresent(ps5Price))
            {
                return "PS5";
            }
        }
        // We do the same with the bike. We only check agaisnt the ps5 because, by reaching this point, we already know we cannot afford it, so
        // the ps5 price doesnt matter. We also dont use an else here, because we want this validation to be done independently of the previous one
        if (bikePrice >= pokemonPlushiePrice)
        {
            if (CanAffordThisPresent(bikePrice))
            {
                return "bike";
            }
        }
        // And finally the same for the plushie. No need to check versus the bike price
        if (CanAffordThisPresent(pokemonPlushiePrice))
        {
            return "pokemon plushie";
        }

        // by default, if we cannot afford anything, we'll reach this line
        return ":(";
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
        if (CanIAffordChristmasPresent())
        {
            return "Congrats! you can afford a " + MostExpensivePresentICanPay();
        }
        else
        {
            return "Sorry, you have to keep saving in order to get a christmas present :(";
        }
    }
}
