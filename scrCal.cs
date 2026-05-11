using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scrCal : MonoBehaviour
{
    public InputField ifCal = null;     //인풋 필드
    public string sText = null;

    public void Btns(string sVal_)
    {
        sText = sText + sVal_;
        RefreshInputField();
    }

    public void BtnBackspace()
    {
        sText = sText.Substring(0, sText.Length - 1);       //마지막 문자열 제거
        RefreshInputField();
    }

    public void RefreshInputField()
    {
        ifCal.text = sText;         //인풋필드 글자 갱신
    }

    public void LogOut()
    {
        SceneManager.LoadScene("Login");
    }
}

