using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
        originPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // forward : z축
        // left : x축
        transform.position = transform.position + transform.forward * speed * Time.deltaTime;
    }


    //private void OnTriggerEnter(Collider other) // Collider가 Trigger인 녀석이 충돌되었을 때 작동하는 이벤트
    //{
    //    Debug.Log($"충돌한 대상 이름 : {other.name}");

    //    // 플레이어가 오브젝트에 충돌했을 때 게임오버
    //}

    private Vector3 originPos;

    private void OnCollisionEnter(Collision collision) // Collider 가 Trigger 가 false 일 때 작동하는 이벤트
    {
        if (collision.collider.CompareTag("Player")) // 객체의 Tag 이름 기준으로 맞는지 아닌지 불리엇 자료형으로 값 도출
        {
            //Destroy(gameObject); // this.gameObject 임 (this 생략 가능)

            // 충돌한 대상 파괴
            Destroy(collision.gameObject);
        }

        if (collision.collider.CompareTag("Wall"))
        {

            // originFos 의 기준이 world 좌표 기준 0, 0, 0 으로 잡혀있어서
            // 자동차가 벽에 충돌 후 world 좌표 0, 0, 0 으로 이동됨.
            transform.position = originPos;
        }
    }

    // OnTriggerEnter 의 OnCollisionEnter 의 차이점 : 트리거는 물리적 충돌이 발생하지 않는다. Collision 물리적 충돌이 발생하고 이벤트도 발생한다.


    // 코드 참고용
    private void PlayerMove()
    {
        // 플레이어의 입력을 받는다.
        float horizontalInput = Input.GetAxis("Horizontal");  
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(horizontalInput, 0, verticalInput);
    }
}
