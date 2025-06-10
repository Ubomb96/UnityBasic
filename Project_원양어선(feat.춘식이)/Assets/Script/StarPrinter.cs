using UnityEngine;
using System;
using System.Text;

public class StarFunctional : MonoBehaviour
{
    const int N = 5;                       // 행열의 최대 크기
    const string SP = "　";                // 공백
    readonly StringBuilder sb = new();

    void Start()
    {
        // Phase 1  (i <= j)
        Print(N, N, (j, i) => i <= j);

        // Phase 2  (i >= j)
        Print(N, N, (j, i) => i >= j);

        // Phase 3  (k = j+1 / 2N-1-j)
        int rows = 2 * N - 1;
        Print(rows, N, (j, i) =>
        {
            int k = (j < N) ? j + 1 : rows - j;
            return i < k;
        });

        // Phase 4  (공백 = |j-(N-1)|)
        Print(rows, N, (j, i) =>
            i >= Mathf.Abs(j - (N - 1)));

        // Phase 5 (맨해튼 거리공식)
        Print(rows, rows, (j, i) =>
            Mathf.Abs(j - (N - 1)) + Mathf.Abs(i - (N - 1)) <= N - 1);
    }


    /// 공통 출력 함수

    void Print(int rows, int cols, Func<int, int, bool> isStar)
    {
        sb.Clear();

        for (int j = 0; j < rows; j++)      // j :(행)
        {
            for (int i = 0; i < cols; i++)  // i :(열)
                sb.Append(isStar(j, i) ? "★" : SP);
            sb.Append('\n');
        }

        Debug.Log(sb.ToString());
    }
}
