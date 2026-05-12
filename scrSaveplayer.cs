using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class scrSaveplayer : MonoBehaviour
{
    //신규 계정 만들기
    //아이디, 패스워드를 리스트로 저장하기
    //인풋필드에 입력된 값을 가져와야한다.
    //로그인 버튼을 누르면 값을 전송한다.

    public InputField id = null;
    public InputField password = null;
    public InputField recheck = null;

    public string sName = string.Empty;
    public string sPassword = string.Empty;

    public void CreateAccount()
    {
        string inputID = id.text;
        string inputPassword = password.text;
        string inputRecheck = recheck.text;

        if (inputID == "")
        {
            Debug.Log("아이디를 입력하십시오.");
            return;
        }

        else if (inputPassword == "")
        {
            Debug.Log("패스워드를 입력하십시오.");
            return;
        }

        else if (inputPassword != inputRecheck)
        {
            Debug.Log("입력하신 비밀번호가 다릅니다.");
            return;
        }
        else
        {
            Debug.Log("알 수 없는 오류입니다.");
        }

        
        PlayerPrefs.SetString(sName, inputID);            //PlayerPrefs.Set타입("키",값)
        PlayerPrefs.SetString(sPassword, inputPassword);

        Debug.Log("회원가입 완료");

        Debug.Log("저장된 아이디 : " + inputID);
        Debug.Log("저장된 비밀번호 : " + inputPassword);

        SceneManager.LoadScene("Login");
    }
    public void CancelLogin()
    {
        id.text = null;
        password.text = null;
        recheck.text = null;
        SceneManager.LoadScene("Login");
    }

    //전체저장
    //전체불러오기
    //한개저장
    //public void SaveUser(string sKey_, user user_) // 키는 고유번호 = Index
    //{
    //
    //    PlayerPrefs.SetString(sKey_ + "ID", user_.sID);
    //    PlayerPrefs.SetString(sKey + "PW", user_.sPW);
    //    
    //}
    //한개불러오기
    //public user LoadUser(string sKey_)
    //{
    //    user userTemp = new user();
    //    userTemp.sName = PlayerPrefs.GetString(sKey + "ID");
    //    userTemp.sPassword = PlayerPrefs.GetString(sKey + "PW");

    //    return userTemp;
    //}




}
