using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Update()
    {
        // Input : 게임 내 입력을 관리하는 클래스
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        if (Input.anyKey)
            Debug.Log("플레이어가 아무 키를 누르고 있습니다.");
    }
}
