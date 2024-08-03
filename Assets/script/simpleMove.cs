using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class simpleMove : MonoBehaviour
{
    // ���� ������ ����ϱ� ���ؼ� public �� �տ� ���̰� ������ �����Ѵ�.
    // const �� ���� ������ �ֱ� ���ؼ� private �� �տ� ���̰� ������ �����Ѵ�.
    [SerializeField] private float speed = 10.0f;

    // 1. �÷��̾��� �Է� �ޱ�
    // 2. ������ �ɾ ����

    // Start is called before the first frame update
    void Start()
    {   

    }

    // Update is called once per frame
    void Update()
    {
        // �Է¿��� �����¿찡 ���� y(����) x,z(�̵�)
        // z (����) , x (������)
        // -z (�ĸ�) , -x (����)

        // -1 ~ 1

        // Input.GetAxis("HorizontalInput"); --> ���������� �Է°��� ���� �� -1, 1
        // Input.GetAxis("Vertical"); --> z ���� 1, -z ���� -1

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(horizontalInput, 0, verticalInput);

        // Time.deltaTime �� Ŭ���̾�Ʈ ������ ���� ������ ���� �Ұ������� ���̱� ���� ����ϴ� ���
        // frame �� ����
        transform.position = transform.position + moveVector * speed * Time.deltaTime;
    }
}
