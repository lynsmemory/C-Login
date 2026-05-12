using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class scrTelDel : MonoBehaviour
{
    public InputField sName = null;
    public InputField sNumber = null;

    public void DelAccount()
    {
        string inputName = sName.text;
        string inputNumber = sNumber.text;

        int index = -1;

        // 이름으로 찾기
        if (inputName != "")
        {
            index = telData.names.IndexOf(inputName);
        }

        // 이름이 없으면 번호로 찾기
        else if (inputNumber != "")
        {
            index = telData.numbers.IndexOf(inputNumber);
        }

        // 찾지 못한 경우
        if (index == -1)
        {
            Debug.Log("일치하는 연락처가 없습니다.");
            return;
        }

        // 같은 인덱스 데이터 삭제
        Debug.Log("삭제된 이름 : " + telData.names[index]);
        Debug.Log("삭제된 번호 : " + telData.numbers[index]);

        telData.names.RemoveAt(index);
        telData.numbers.RemoveAt(index);

        Debug.Log("연락처 삭제 완료");

        // 입력창 초기화
        sName.text = "";
        sNumber.text = "";

    }
}
