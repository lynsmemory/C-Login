using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scrLogin : MonoBehaviour
{
    public InputField loginID = null;
    public InputField loginPassword = null;

    // 로그인 버튼
    public void Login()
    {
        string inputID = loginID.text;
        string inputPassword = loginPassword.text;

        bool success = false;

        // 저장된 계정 검사
        for (int i = 0; i < UserDatabase.ids.Count; i++)
        {
            if (inputID == UserDatabase.ids[i] &&
               inputPassword == UserDatabase.passwords[i])
            {
                success = true;
                break;
            }
        }

        // 결과
        if (success == true)
        {
            Debug.Log("로그인 성공");

            // 다음 씬 이동
            SceneManager.LoadScene("SampleScene");
        }
        else
        {
            Debug.Log("아이디 또는 비밀번호가 틀렸습니다.");
        }
    }

    // 회원가입 씬 이동 버튼
    public void GoToRegister()
    {
        SceneManager.LoadScene("CreateAccount");
    }
}