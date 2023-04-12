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

    // ���� ����

    // Update : ���� ���� ������Ʈ
    // ȯ�濡 ���� ���� ������ ������ �� �ִ�.
    private void Update()
    {
        Debug.Log("���� ���!!");
    }

    // ��� ������Ʈ ���� ��
    private void LateUpdate()
    {
        Debug.Log("����ġ ȹ��.");
    }

    // ��ü

    // OnDestroy : ���� ������Ʈ�� ������ ��
    private void OnDestroy()
    {
        Debug.Log("�÷��̾� �����͸� �����Ͽ����ϴ�.");
    }
}