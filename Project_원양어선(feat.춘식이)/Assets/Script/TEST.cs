using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

/* Debug 활용 실습
 
public class TEST : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("최초 한번만 실행됩니다.");
    }

    void OnEnable()
    {
        Debug.Log("활성화 될 때 실행됩니다.");
    }

    void Start()
    {
        Debug.Log("한번만 실행됩니다.");
    }

    void Update()
    {
        Debug.Log("매 프레임마다 여러번 실행됩니다.");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
*/

/*public class Player
{
    private int playerLevel = 10;

    public int Level()
    {
        return playerLevel;
    }
}

public class Monster
{
    private int monsterLevel;

    public void SetLevel(int _playerLevel)
    {
        monsterLevel = _playerLevel;
    }
}

public class Game
{
    Player A;
    Monster B;

    void MonsterSpawn() // 몬스터
    {
        B.SetLevel(A.Level());
    }
}*/

//public class TEST : MonoBehaviour
//{
//    void OnEnable()
//    {
//        Debug.Log(Random.Range(1, 100));
//        // 1 이상 100 미만의 랜덤한 값을 만들겠다.
//    }
//}


//실습1번
public class MySelf : MonoBehaviour
{
    // 🔹 속성 10개 (다양한 변수 타입을 고려해서 잘 골라준다.)
    public string myName = "원중완";
    public int age = 30;
    public float height = 183.2f;
    public float weight = 89.3f;
    public string mbti = "INTP";
    public bool likesGames = true;
    public string favoriteGames = "로스트아크 ";
    public int gameExperience = 15; // 단위: 년
    public string favoriteFood = "삼겹살";
    public string hateThing = "코딩";

    // 🔹 Start 함수에서 PrintInfo() 호출
    void Start() // 딱 한번만 호출하고 리턴을 받지 않을 것이므로 void start 함수를 사용 <-> 리턴을 요구한다면 정수 : int함수를 사용, 문자열 : string 함수사용
    {
        PrintInfo(); // 각각의 Debug.Log를 통한 호출
        PrintInfoA(); // $@"문법 사용으로 한 자기소개 호출
    }

    // 🔹 PrintInfo(): 속성 콘솔에 출력
    void PrintInfo()
    {
        Debug.Log("=== 나를 소개합니다! ===");
        Debug.Log("이름: " + myName);
        Debug.Log("나이: " + age);
        Debug.Log("키: " + height + "cm");
        Debug.Log("몸무게: " + weight + "kg");
        Debug.Log("MBTI: " + mbti);
        Debug.Log("게임 좋아함?: " + likesGames);
        Debug.Log("가장좋아하는 게임: " + favoriteGames);
        Debug.Log("게임 경력: " + gameExperience + "년");
        Debug.Log("좋아하는 음식: " + favoriteFood);
        Debug.Log("싫어하는 것은?: " + hateThing);
    }

    void PrintInfoA()
    {
        string summary = $@"
----- 요약 출력 -----
이름: {myName}
나이: {age}
키: {height}cm, 몸무게: {weight}kg
MBTI: {mbti}
게임을 좋아하나요?: {likesGames}
좋아하는 게임: {favoriteGames}
게임 경력: {gameExperience}년
좋아하는 음식: {favoriteFood}
싫어하는 것: {hateThing}
---------------------";

        Debug.Log(summary);
    }
}








    