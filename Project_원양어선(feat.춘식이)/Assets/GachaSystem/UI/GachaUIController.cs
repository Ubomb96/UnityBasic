using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GachaUIController : MonoBehaviour
{
    [Header("참조")]
    public GachaSystem gacha;           // GachaManager 오브젝트
    public Button drawButton;      // “10+1 뽑기” 버튼
    public GameObject resultPanel;     // 결과 패널 (비활성 → 활성)
    public TextMeshProUGUI resultText;      // 결과를 보여줄 TMP_Text
    public Button closeButton;     // 결과 패널 닫기 버튼

    void Start()
    {
        drawButton.onClick.AddListener(OnClickDraw);
        closeButton.onClick.AddListener(() => resultPanel.SetActive(false));
        resultPanel.SetActive(false);
    }

    /* 버튼 클릭 → 뽑기 → 결과 출력 */
    void OnClickDraw()
    {
        List<Character> pulled = gacha.DrawTenPlusOne();
        ShowResults(pulled);
    }

    void ShowResults(List<Character> list)
    {
        var sb = new StringBuilder();
        sb.AppendLine("<size=36><b>10 + 1 결과</b></size>\n");

        int n = 1;
        foreach (var c in list)
        {
            string color = c.Rarity switch { 5 => "#FFD700", 4 => "#C9E4FF", _ => "#FFFFFF" };
            sb.AppendLine($"{n++,2}. {c.Name}  <color={color}>{c.Rarity}★</color>");
        }

        resultText.text = sb.ToString();
        resultPanel.SetActive(true);
    }
}
