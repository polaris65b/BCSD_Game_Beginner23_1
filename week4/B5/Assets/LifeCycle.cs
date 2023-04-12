using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    //초기화

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

    // 활성호

    // OnEnable() : 게임 오브젝트가 활성되었을 때
    private void OnEnable()
    {
        Debug.Log("플레이어 로그인!");
    }
    // 물리

    //FixedUpdate : 물리 연산 업데이트
    // 고정된 실행 주기로 CPU를 많이 사용.
    private void FixedUpdate()
    {
        Debug.Log("이동~");
    }

    // 게임 로직

    // Update : 게임 로직 업데이트
    // 환경에 따라 실행 주지가 떨어질 수 있다.
    private void Update()
    {
        Debug.Log("몬스터 사냥!!");
    }

    // 모든 업데이트 끝난 후
    private void LateUpdate()
    {
        Debug.Log("경험치 획득.");
    }

    // 비활성화
    // OnDisable : 게임 오브젝트가 비활성화 되었을 때
    private void OnDisable()
    {
        Debug.Log("플레이어 로그아웃");
    }

    // 해체

    // OnDestroy : 게임 오브젝트가 삭제될 때
    private void OnDestroy()
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }

}