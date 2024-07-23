using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    // �������� �������:

    public Text DialogText; // ���������� � ������� ����� ���� ������
    public string[] DialogMessage; // ������ ��������� ���������� ��� ���������� �������������

    int arrayIndex = 0; // ������ ������� (��� �� �� ������ ����� �������)
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DialogText.text = DialogMessage[arrayIndex];

            if (arrayIndex < DialogMessage.Length - 1) // ���� arrayIndex ������ ����� �������. ��� �����, ��� �� ���� ������ �� 2 ���������, �� �� ������� 3-��
            { // ������ ������� ���������� � ����. ������� ���� ����� ������� 10, �� ��������� ������� ������� ��� 9. � ��� ����� �������� �� ����� ������� 1
                arrayIndex++;
            }
            else // ����� �������� ������. � ������ ���������� ������
            {
                arrayIndex = 0;
            }
        }
    }
}
