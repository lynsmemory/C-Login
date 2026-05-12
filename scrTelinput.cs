using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scrTelinput : MonoBehaviour
{

    //이름, 연락처 추가하기
    //이름, 연락처를 리스트로 저장하기
    //인풋필드에 입력된 값을 가져오기
    //추가버튼을 누르면 저장된다.

    public InputField sName = null;
    public InputField sNumber = null;

    public void CreateAccount()
    {
        string inputName = sName.text;
        string inputNumber = sNumber.text;

        if (inputName == "")
        {
            Debug.Log("이름을 입력하십시오.");
            return;
        }

        if (inputNumber == "")
        {
            Debug.Log("연락처를 입력하십시오.");
            return;
        }

        

        telData.names.Add(inputName);
        telData.numbers.Add(inputNumber);

        Debug.Log("연락처 저장 완료");
        int lastIndex = telData.names.Count - 1;

        Debug.Log("저장된 이름 : " + telData.names[lastIndex]);
        Debug.Log("저장된 연락처 : " + telData.numbers[lastIndex]);

        // 입력창 초기화
        sName.text = "";
        sNumber.text = "";

    }




}
