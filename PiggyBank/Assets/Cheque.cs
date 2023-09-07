using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheque : MonoBehaviour
{
    // --------- ATTRIBUTES ----------

    [SerializeField] private string issuedBy;

    [SerializeField] private string issuedTo;

    [SerializeField] private float amount;
    
    private bool hasBeenCashed;

    // --------- FUNCTIONS ----------

    public string GetIssuedBy()
    {
        return issuedBy;
    }

    public float GetAmount()
    {
        return amount;
    }

    public void CashOut()
    {
        hasBeenCashed = true;
    }
}
