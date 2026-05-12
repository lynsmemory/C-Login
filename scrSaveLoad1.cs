using System;
using UnityEngine;

public class scrSaveLoad1 : MonoBehaviour
{
    public string sName = string.Empty;
    public int nIndex = -1;
    public bool bUse = false;
    public float fTime = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Load();
    }

    // Update is called once per frame
    private void OnApplicationQuit()
    {
        Save();
    }

    public void Load()
    {
        sName = PlayerPrefs.GetString("asd");
        nIndex = PlayerPrefs.GetInt("asd");
        //bUse = Convert.ToBoolean(PlayerPrefs.GetString("zxc"));        //string을 bool로 바꾸는 방법?
        fTime = PlayerPrefs.GetFloat("123");
    }
    public void Save()
    {
        PlayerPrefs.SetString("qwe", sName);            //PlayerPrefs.Set타입("키",값)
        PlayerPrefs.SetInt("asd", nIndex);
        //PlayerPrefs.SetString("zxc", bUse.ToString());        
        PlayerPrefs.GetFloat("123", fTime);
    }
}
