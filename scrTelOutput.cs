using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scrTelOutput : MonoBehaviour
{
    

    // 찾기 버튼

    // 버튼 클릭 시 실행
    public void Load()
    {
        // 기존 내용 초기화
        

        // 저장된 연락처 개수만큼 반복
        for (int i = 0; i < telData.names.Count; i++)
        {
            Debug.Log(
                "이름 : " + telData.names[i] +
                " / 번호 : " + telData.numbers[i] + "\n");
            
        }

        Debug.Log("연락처 불러오기 완료");
    }
}
        //string inputID = loginID.text;
        //string inputPassword = loginPassword.text;
        //
        //bool success = false;
        //
        //// 저장된 계정 검사
        //for (int i = 0; i < TelDatabase.ids.Count; i++)
        //{
        //    if (inputID == TelDatabase.ids[i] &&
        //       inputPassword == TelDatabase.passwords[i])
        //    {
        //        success = true;
        //        break;
        //    }
        //}
        //
        //// 결과
        //if (success == true)
        //{
        //    Debug.Log("로그인 성공");
        //
        //    // 다음 씬 이동
        //    SceneManager.LoadScene("SampleScene");
        //}
        //else
        //{
        //    Debug.Log("아이디 또는 비밀번호가 틀렸습니다.");
        //}
    

  