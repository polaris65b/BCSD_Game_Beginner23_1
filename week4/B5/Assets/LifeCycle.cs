using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //�ʱ�ȭ

    // Awake : ���� ������Ʈ ������ ��, ���� ����
    void Awake()
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }

    // Start : ������Ʈ ���� ����, ���� ����
    private void Start()
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }

    // ����

    //FixedUpdate : ���� ���� ������Ʈ
    // ������ ���� �ֱ�� CPU�� ���� ���.
    private void FixedUpdate()
    {
        Debug.Log("�̵�~");
    }
}