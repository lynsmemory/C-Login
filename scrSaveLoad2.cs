using System;
using UnityEngine;

public class scrSaveLoad2 : MonoBehaviour
{

    [SerializeField] public string sName = "Object";
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
        //Position 불러오기
        float x = PlayerPrefs.GetFloat(sName + "_Posx");
        float y = PlayerPrefs.GetFloat(sName + "_Posy");
        float z = PlayerPrefs.GetFloat(sName + "_Posz");
        transform.position = new Vector3(x, y, z);

        //Rotation 불러오기
        float rx = PlayerPrefs.GetFloat(sName + "_Rotx");
        float ry = PlayerPrefs.GetFloat(sName + "_Roty");
        float rz = PlayerPrefs.GetFloat(sName + "_Rotz");
        transform.eulerAngles = new Vector3(rx, ry, rz);

        //Position 불러오기
        float px = PlayerPrefs.GetFloat(sName + "_Sclx");
        float py = PlayerPrefs.GetFloat(sName + "_Scly");
        float pz = PlayerPrefs.GetFloat(sName + "_Sclz");
        transform.localScale = new Vector3(px, py, pz);
    }
    public void Save()
    {
        //Position x y z 저장
        PlayerPrefs.SetFloat(sName + "_Posx", transform.position.x);
        PlayerPrefs.SetFloat(sName + "_Posy", transform.position.y);
        PlayerPrefs.SetFloat(sName + "_Posz", transform.position.z);

        //Rotation x y z 저장
        PlayerPrefs.SetFloat(sName + "_Rotx", transform.rotation.x);
        PlayerPrefs.SetFloat(sName + "_Roty", transform.rotation.y);
        PlayerPrefs.SetFloat(sName + "_Rotz", transform.rotation.z);

        //Scale x y z 저장
        PlayerPrefs.SetFloat(sName + "_Sclx", transform.localScale.x);
        PlayerPrefs.SetFloat(sName + "_Scly", transform.localScale.y);
        PlayerPrefs.SetFloat(sName + "_Sclz", transform.localScale.z);

    }

}
