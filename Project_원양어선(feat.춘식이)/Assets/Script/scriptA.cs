using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class scriptA : MonoBehaviour
{
    public TextMeshProUGUI Txt_Text; // �ؽ�Ʈ ��� ����

    [SerializeField] TMP_InputField Input_Text; // �ؽ�Ʈ �Է� ����

    public void OnclickButton() // ��ư�� ������ ����
    {
        Txt_Text.text = Input_Text.text;
    }
}
