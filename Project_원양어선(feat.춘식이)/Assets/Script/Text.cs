using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start() {
        //✅유니티의 주석은 '//'을 사용한다. +  /+ */이거는 범위 주석으로 사용된다. + ctrl KC로 주석처리 ctrl KU로 되돌리기 가능

        //✅Debug.Log의 역할은 로블록스에서 print의 역할과 비슷한 역할을 한다. 콘솔창에 로그를 띄워주는 역할이 메인이다.

        //✅TMI
           //Debug.Log("내용") : 하얀색으로 표시되는 기본 로그
           //Debug.LogWarning("내용) : 앞의 아이콘이 노란색 !로 표기
           //Debug.LogWarning("내용") : 앞의 아이콘이 빨간색으로 표기
    
           //이런 것들도 있습니다.하지만 플머가 노란색, 빨간색으로 뜨면 싫어하니 Log정도만 사용하셔도 됩니다
           //Debug.Log("안녕하세요");
           //Debug.Log("반갑습니다"); //유니티에서 모든 문장의 끝에는 반드시 세미콜론(;)을 사용해 주어야한다.

           //만약에 줄의 들여쓰기 수준이 꼬여있다면 ctrl + K + D를 누르면 자동정렬을 해준다
    }


    //✅ 예시로 Start 함수
    //void : 반환되는 값이 없다면 void로 표시합니다.
    //Start : 함수의 이름
    //() : 비어있다면 전달받는 값이 없다는 의미입니다.
    //{} : 함수에 동작될 기능입니다.





    // Update is called once per frame
    void Update()
    {

    }
}
//✅이벤트 함수의 실행순서
//Awake : 오브젝트가 생성되고 활성화될 때 가장 먼저 호출(동작)됩니다. -- 최초 1회
//OnEnable : 오브젝트가 활성화 될 때 Awake 다음으로 호출됩니다. -- 비활성화 → 활성화 될 때마다 호출됩니다.
//Start : OnEnable 다음으로 동작합니다. -- 1번만 동작합니다.
//Update : 계속해서 계산하고 실행해야 할 동작이 있다면 Update에서 실행합니다. -- 매 프레임마다 호출됩니다.
//OnDisable : 오브젝트가 비활성화 될 때 호출됩니다. -- 활성화 → 비활성화 될 때마다 호출됩니다.
//OnDestroy : 오브젝트가 삭제될 때 호출됩니다. -- 1회만 호출



//✅식별자와 표기법//


//클래스, 함수, 변수 등을 구분하기 위해 식별자를 작성
//식별자는 이름만으로 요소의 특징을 알 수 있어야함
//고유성 + 가독성 필요
//ex) playerLevel(o) / playerLv(o) / L(x)

//규칙은 함께 일하는 팀뿐만 아니라 프로그램과도 규칙을 맞춰야 함
//카멜(단봉) 표기법 : plyerName, maxLevel 등 중간의 글자를 대문자로
//파스칼(쌍봉) 표기법 : PlayerName, MaxLevel 등 첫글자와 중간 글자를 대문자로
//스네이크 표기법 : player_name 등 띄어쓰기에 _언더라인 사용


//✅접근 지정자

//사용예시 : Player의 Level에 비례하여 Monster의 Level을 설정하고 싶을 수 있습니다.

//Public vs Private

//몬스터가 플레이어에게 정보 공개 요청

//YES --> Public NO --> Private

//클래스에서는 Private 접근 지정자는 생략할 수도 있음

//그 밖에도 부모 자식의 상속관계에서만 접근 가능한 Protected도 있음



//✅ Unity C# 스크립트 기본 구조
//using UnityEngine; // 유니티 기능을 사용하기 위한 네임스페이스

//public class Player : MonoBehaviour  // 클래스 이름은 파일명과 같아야 해!
//{
//    // 필드: 변수들 (데이터 보관)
//    public int hp = 100;

//    // Start(): 게임이 시작될 때 한 번 실행됨
//    void Start()
//    {
//        Debug.Log("게임 시작!");  // 콘솔에 출력
//    }

  
//    void Update() -- Update(): 매 프레임마다 실행됨 (1초에 수십 번)
//    {
//        Debug.Log("프레임마다 실행 중...");
//    }
//}