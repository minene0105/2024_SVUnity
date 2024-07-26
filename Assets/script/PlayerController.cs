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
    void Update()
    {
        characterController.SimpleMove(Vector3.left * speeds);
    }
}
