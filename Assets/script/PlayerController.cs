using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // �ּ�
    public CharacterController characterController; // �ʷϻ� �̸� Ÿ�� - ��� �̸� ����
    public float speeds = 10f;                      // �ʱ� �ӵ��� 10���� ����

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
        // �÷��̾��� �Է��� �޴´�.
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(horizontalInput, 0, verticalInput);

        // Time.deltaTime �� SimpleMove �Լ� �ȿ��� ����ǰ� ����.
        characterController.SimpleMove(moveVector * speeds); // speed �� ����� �ӵ�
    }

    private void PlayerCameraMove()
    {
        // �÷��̾��� ���콺 �Է� ����.
        float MouseX = Input.GetAxis("Mouse X");
        Debug.Log($"Mouse X {MouseX}");
        float MouseY = Input.GetAxis("Mouse Y");
        Debug.Log($"Mouse Y {MouseY}");

        
        // transform �� ���� , y���� MouseX �� ��ŭ ������ �ָ� �ȴ�.
        transform.rotation = Quaternion.Euler( MouseX, MouseY, 0 );


    }
}
