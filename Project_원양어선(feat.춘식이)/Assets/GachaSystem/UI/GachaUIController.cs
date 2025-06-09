using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GachaUIController : MonoBehaviour
{
    [Header("����")]
    public GachaSystem gacha;           // GachaManager ������Ʈ
    public Button drawButton;      // ��10+1 �̱⡱ ��ư
    public GameObject resultPanel;     // ��� �г� (��Ȱ�� �� Ȱ��)
    public TextMeshProUGUI resultText;      // ����� ������ TMP_Text
    public Button closeButton;     // ��� �г� �ݱ� ��ư

    void Start()
    {
        drawButton.onClick.AddListener(OnClickDraw);
        closeButton.onClick.AddListener(() => resultPanel.SetActive(false));
        resultPanel.SetActive(false);
    }

    /* ��ư Ŭ�� �� �̱� �� ��� ��� */
    void OnClickDraw()
    {
        List<Character> pulled = gacha.DrawTenPlusOne();
        ShowResults(pulled);
    }

    void ShowResults(List<Character> list)
    {
        var sb = new StringBuilder();
        sb.AppendLine("<size=36><b>10 + 1 ���</b></size>\n");

        int n = 1;
        foreach (var c in list)
        {
            string color = c.Rarity switch { 5 => "#FFD700", 4 => "#C9E4FF", _ => "#FFFFFF" };
            sb.AppendLine($"{n++,2}. {c.Name}  <color={color}>{c.Rarity}��</color>");
        }

        resultText.text = sb.ToString();
        resultPanel.SetActive(true);
    }
}
