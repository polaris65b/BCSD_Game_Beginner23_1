using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // Awake : 게임 오브젝트 생성할 때, 최초 실행
    void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    // Start : 업데이트 시작 직전, 최초 실행
    private void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }
}
