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
    void Update()
    {
        characterController.SimpleMove(Vector3.left * speeds);
    }
}
