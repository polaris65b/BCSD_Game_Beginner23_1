using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Update()
    {
        // Input : ���� �� �Է��� �����ϴ� Ŭ����
        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("�������� �����Ͽ����ϴ�.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("�������� �̵� ��");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("������ �̵��� ���߾����ϴ�.");
    }
}
