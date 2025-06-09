using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scriptA : MonoBehaviour
{
    public TextMeshProUGUI Txt_Text; // 텍스트 출력 구간

    [SerializeField] TMP_InputField Input_Text; // 텍스트 입력 구간

    public void OnclickButton() // 버튼을 누르면 실행
    {
        Txt_Text.text = Input_Text.text;
    }
}
