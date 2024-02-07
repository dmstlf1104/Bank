using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{
    public void Exit()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Deposit()
    {
        SceneManager.LoadScene("Deposit");
    }

    public void Withdraw()
    {
        SceneManager.LoadScene("Withdraw");
    }
}
