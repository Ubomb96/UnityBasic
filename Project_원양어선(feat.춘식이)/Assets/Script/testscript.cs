
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

// public class testscript : MonoBehaviour
// {
    // Start is called before the first frame update

    // public int gold = 0;

    // void Awake()
    // {
        // Debug.Log("최초한번 실행");
    // }

   // void OnEnable()
   // {
   //     Debug.Log("활성화 될 때 실행");   
   // }
    // void Start()
    // {
      //   Debug.Log("안녕하세요");
       //  Debug.Log("감사해요");
     //    UnityEngine.Debug.Log("잘있어요");
       //  UnityEngine.Debug.Log("다시만나요");
    // }

    // Update is called once per frame
   //  void Update()
    // {
      //   Debug.Log("여러번 실행");
    // }

   //  int Sum(int value1, int value2)
   //  { 
    //     return value1 + value2; 
  //   }
 //    void OnEnable()
  //   {
   //      Debug.Log(Random.Range(1, 100));
        // 1 이상 100 미만의 랜덤한 값을 만들겠다.

  //   }
// }
// public class Monster
// {
   //  testscript test;

   //  void Attack()
  //   {
    //     test.gold = 0;
  //   }

// }

public class testA : MonoBehaviour
{
    private string aname = "식빵";
    private int MFD = 20;
    private float life = 1200.0f;

    void Start()
    {
        SelfIntroduction();
        SelfIntroduction(aname, MFD);

    }

    public void SelfIntroduction()
    {
        Debug.Log("이것의 이름은" + aname + "입니다.");
        Debug.Log("제조일은" + MFD + "일 입니다.");
        Debug.Log("앞으로의 수명은" + life + "초 남았습니다.");

    }
    
    public void SelfIntroduction(string _aname, int _MFD)
    {
        Debug.Log("이것" + _aname + "임");
        Debug.Log("제조일" + _MFD + "일");
    }
}