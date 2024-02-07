using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.Windows;

public class GameManager : MonoBehaviour
{
    public InputField ID;
    public InputField NAME;
    public InputField PS;
    public InputField PSConfirm;

    [SerializeField]
    private Text txt_error;

    public void Start()
    {
       
    }

    public void Save() //저장
    {
        PlayerPrefs.SetString("ID", ID.text);
        PlayerPrefs.SetString("NAME", NAME.text);
        PlayerPrefs.SetString("PS", PS.text);
        PlayerPrefs.SetString("PSC", PSConfirm.text);

        string IDinput = PlayerPrefs.GetString("ID");
        string NAMEinput = PlayerPrefs.GetString("NAME");
        string PSinput = PlayerPrefs.GetString("PS");
        string PSCinput = PlayerPrefs.GetString("PSC");

        if (string.IsNullOrEmpty(IDinput) || string.IsNullOrEmpty(NAMEinput)
            || string.IsNullOrEmpty(PSinput) || string.IsNullOrEmpty(PSCinput))
        {
            txt_error.text = "칸이 비어있는 지 확인해주세요.";
            return;
        }

        if (PlayerPrefs.HasKey(IDinput))
        {
            txt_error.text = ("이미 사용자가 존재합니다.");
            return;
        }

        PlayerPrefs.SetString(IDinput, PSinput);
        PlayerPrefs.Save();

    }
}