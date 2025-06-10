using UnityEngine;
using System;
using System.Text;

public class StarFunctional : MonoBehaviour
{
    const int N = 5;                       // �࿭�� �ִ� ũ��
    const string SP = "��";                // ����
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

        // Phase 4  (���� = |j-(N-1)|)
        Print(rows, N, (j, i) =>
            i >= Mathf.Abs(j - (N - 1)));

        // Phase 5 (����ư �Ÿ�����)
        Print(rows, rows, (j, i) =>
            Mathf.Abs(j - (N - 1)) + Mathf.Abs(i - (N - 1)) <= N - 1);
    }


    /// ���� ��� �Լ�

    void Print(int rows, int cols, Func<int, int, bool> isStar)
    {
        sb.Clear();

        for (int j = 0; j < rows; j++)      // j :(��)
        {
            for (int i = 0; i < cols; i++)  // i :(��)
                sb.Append(isStar(j, i) ? "��" : SP);
            sb.Append('\n');
        }

        Debug.Log(sb.ToString());
    }
}
