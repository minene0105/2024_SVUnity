using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // 주석
    public CharacterController characterController; // 초록색 이름 타입 - 흰색 이름 변수
    public float speeds = 10f;                      // 초기 속도를 10으로 설정

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        PlayerMove();
        PlayerCameraMove();
    }

    private void PlayerMove()
    {
        // 플레이어의 입력을 받는다.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(horizontalInput, 0, verticalInput);

        // Time.deltaTime 이 SimpleMove 함수 안에서 적용되고 있음.
        characterController.SimpleMove(moveVector * speeds); // speed 는 방향과 속도
    }

    private void PlayerCameraMove()
    {
        // 플레이어의 마우스 입력 받음.
        float MouseX = Input.GetAxis("Mouse X");
        Debug.Log($"Mouse X {MouseX}");
        float MouseY = Input.GetAxis("Mouse Y");
        Debug.Log($"Mouse Y {MouseY}");

        
        // transform 의 각도 , y축을 MouseX 값 만큼 변경해 주면 된다.
        transform.rotation = Quaternion.Euler( MouseX, MouseY, 0 );


    }
}
