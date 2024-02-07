using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class price : MonoBehaviour
{

    [SerializeField]
    private Text txt_money;

    [SerializeField]
    private Text banlance;

    [SerializeField]
    private InputField inputTxT_Money;

    [SerializeField]
    private GameObject noMoneyPanel;

    private int current_Money = 100000; //기본 현금 10만원
    private int Banlance = 50000;
    public void Start()
    {
        UpdateMoneyText();
    }
    public void Input() //입력받은 돈 입금
    {
        if (int.TryParse(inputTxT_Money.text, out int amount))
        {
            OnButtonClickInput(amount);
        }
    }
    
    public void Output() //입력받은 돈 출금
    {
        if (int.TryParse(inputTxT_Money.text, out int amount))
        {
            OnButtonClickOutput(amount);
        }
        
    }

    private void UpdateMoneyText()
    {
        txt_money.text = string.Format("{0:#,##0}", current_Money);
        banlance.text = string.Format("{0:#,##0}", Banlance);
    }

    public void Exit()
    {
        {
            noMoneyPanel.SetActive(false);
        }
    }


    public void OnButtonClickInput(int money) //버튼돈 입금
    {
        if (current_Money >= money)
        {
            current_Money -= money;
            Banlance += money;
            UpdateMoneyText();
        }
        else
        {
            noMoneyPanel.SetActive(true);
        }
    }

    public void OnButtonClickOutput(int money) //버튼돈 출금
    {
        if (Banlance >= money)
        {
            Banlance -= money;
            current_Money += money;
            UpdateMoneyText();
        }
        else
        {
            noMoneyPanel.SetActive(true);
        }
    }
}
