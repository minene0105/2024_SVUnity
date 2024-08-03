using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class simpleMove : MonoBehaviour
{
    // 전역 변수로 사용하기 위해선 public 을 앞에 붙이고 변수를 선언한다.
    // const 와 같은 역할을 주기 위해선 private 를 앞에 붙이고 변수를 선언한다.
    [SerializeField] private float speed = 10.0f;

    // 1. 플레이어의 입력 받기
    // 2. 조건을 걸어서 실행

    // Start is called before the first frame update
    void Start()
    {   

    }

    // Update is called once per frame
    void Update()
    {
        // 입력에는 상하좌우가 있음 y(점프) x,z(이동)
        // z (정면) , x (오른쪽)
        // -z (후면) , -x (왼쪽)

        // -1 ~ 1

        // Input.GetAxis("HorizontalInput"); --> 수평적으로 입력값을 받을 떄 -1, 1
        // Input.GetAxis("Vertical"); --> z 방향 1, -z 방향 -1

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(horizontalInput, 0, verticalInput);

        // Time.deltaTime 은 클라이언트 끼리의 성능 격차에 따른 불공정함을 줄이기 위해 사용하는 기능
        // frame 의 역수
        transform.position = transform.position + moveVector * speed * Time.deltaTime;
    }
}
