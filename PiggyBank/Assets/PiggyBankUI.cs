using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PiggyBankUI : MonoBehaviour
{
    [SerializeField] private PiggyBank piggyBank;
    [SerializeField] private Button add10Btn;
    [SerializeField] private Button add25Btn;
    [SerializeField] private Button add50Btn;

    [SerializeField] private Button action1Btn;
    [SerializeField] private Button action2Btn;
    
    [SerializeField] private Button txt1Btn;
    [SerializeField] private Button txt2Btn;
    [SerializeField] private Button txt3Btn;
    [SerializeField] private Button txt4Btn;
    [SerializeField] private Button closeAlert;

    [SerializeField] private GameObject alert;
    [SerializeField] private TextMeshProUGUI alertText;

    private void Start()
    {
        add10Btn.onClick.AddListener(piggyBank.Add10);
        add25Btn.onClick.AddListener(piggyBank.Add25);
        add50Btn.onClick.AddListener(piggyBank.Add50);

        action1Btn.onClick.AddListener(piggyBank.DoAction1);
        action2Btn.onClick.AddListener(piggyBank.DoAction2);

        txt1Btn.onClick.AddListener(PrintText1);
        txt2Btn.onClick.AddListener(PrintText2);
        txt3Btn.onClick.AddListener(PrintText3);
        txt4Btn.onClick.AddListener(PrintText4);

        closeAlert.onClick.AddListener(() => { alert.SetActive(false); });
    }

    private void PrintText1()
    {
        alert.SetActive(true);
        alertText.text = piggyBank.GetText1();
    }

    private void PrintText2()
    {
        alert.SetActive(true);
        alertText.text = piggyBank.GetText2();
    }

    private void PrintText3()
    {
        alert.SetActive(true);
        alertText.text = piggyBank.GetText3();
    }

    private void PrintText4()
    {
        alert.SetActive(true);
        alertText.text = piggyBank.GetText4();
    }
}
