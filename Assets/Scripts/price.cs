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

    private int current_Money = 100000; //�⺻ ���� 10����
    private int Banlance = 50000;
    public void Start()
    {
        UpdateMoneyText();
    }
    public void Input() //�Է¹��� �� �Ա�
    {
        if (int.TryParse(inputTxT_Money.text, out int amount))
        {
            OnButtonClickInput(amount);
        }
    }
    
    public void Output() //�Է¹��� �� ���
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


    public void OnButtonClickInput(int money) //��ư�� �Ա�
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

    public void OnButtonClickOutput(int money) //��ư�� ���
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
