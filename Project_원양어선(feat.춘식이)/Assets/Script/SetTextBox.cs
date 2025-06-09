using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SetTextBox : MonoBehaviour
{
    public TextMeshProUGUI Txt_Text; //텍스트를 넣을 곳
    [SerializeField] TMP_InputField Input_Text;

    public void OnclickButton()
    {
        Txt_Text.text = Input_Text.text;
    }

}