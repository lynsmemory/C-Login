using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scrCreateAccount : MonoBehaviour
{
    //신규 계정 만들기
    //아이디, 패스워드를 리스트로 저장하기
    //인풋필드에 입력된 값을 가져와야한다.
    //로그인 버튼을 누르면 값을 전송한다.

    public InputField id = null;
    public InputField password = null;
    public InputField recheck = null;

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

        UserDatabase.ids.Add(inputID);
        UserDatabase.passwords.Add(inputPassword);

        Debug.Log("회원가입 완료");

        Debug.Log("저장된 아이디 : " + UserDatabase.ids[0]);
        Debug.Log("저장된 비밀번호 : " + UserDatabase.passwords[0]);

        SceneManager.LoadScene("Login");
    }
    public void CancelLogin()
    {
        id.text = null;
        password.text = null;
        recheck.text = null;
        SceneManager.LoadScene("Login");
    }


    
    
}
