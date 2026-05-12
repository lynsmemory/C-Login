using UnityEngine;

public class scrAutoObject : MonoBehaviour
{
    public string sKey = string.Empty;
    

    public void OnEnable()
    {
        Load();
    }

    public void OnDisable()
    {
        Save();
    }



    public void Load()
    {
        //float fPosx = PlayerPrefs.GetFloat(sKey + "Posx");
        //float fPosy = PlayerPrefs.GetFloat(sKey + "Posy");
        //float fPosz = PlayerPrefs.GetFloat(sKey + "Posz");
        //transform.position = new Vector3(fPosx, fPosy, fPosz);
        //위와 동일한 코드
        transform.position = new Vector3
            (PlayerPrefs.GetFloat(sKey + "Posx"), 
            PlayerPrefs.GetFloat(sKey + "Posy"), 
            PlayerPrefs.GetFloat(sKey + "Posz"));

        //float fRotx = PlayerPrefs.GetFloat(sKey + "Rotx");
        //float fRoty = PlayerPrefs.GetFloat(sKey + "Roty");
        //float fRotz = PlayerPrefs.GetFloat(sKey + "Rotz");
        //transform.eulerAngles = new Vector3(fRotx, fRoty, fRotz);
        transform.eulerAngles = new Vector3
            (PlayerPrefs.GetFloat(sKey + "Rotx"), 
            PlayerPrefs.GetFloat(sKey + "Roty"), 
            PlayerPrefs.GetFloat(sKey + "Rotz"));

        //float fSclx = PlayerPrefs.GetFloat(sKey + "Sclx");
        //float fScly = PlayerPrefs.GetFloat(sKey + "Scly");
        //float fSclz = PlayerPrefs.GetFloat(sKey + "Sclz");
        //transform.localScale = new Vector3(fSclx, fScly, fSclz);
        transform.localScale = new Vector3
            (PlayerPrefs.GetFloat(sKey + "Sclx"),
            PlayerPrefs.GetFloat(sKey + "Scly"),
            PlayerPrefs.GetFloat(sKey + "Sclz"));
    }

    public void Save()
    {
        PlayerPrefs.SetFloat(sKey + "Posx",transform.position.x);
        PlayerPrefs.SetFloat(sKey + "Posy", transform.position.y);
        PlayerPrefs.SetFloat(sKey + "Posz", transform.position.z);

        PlayerPrefs.SetFloat(sKey + "Rotx", transform.localEulerAngles.x);
        PlayerPrefs.SetFloat(sKey + "Roty", transform.localEulerAngles.y);
        PlayerPrefs.SetFloat(sKey + "Rotz", transform.localEulerAngles.z);

        PlayerPrefs.SetFloat(sKey + "Sclx", transform.localScale.x);
        PlayerPrefs.SetFloat(sKey + "Scly", transform.localScale.y);
        PlayerPrefs.SetFloat(sKey + "Sclz", transform.localScale.z);
    }
}
