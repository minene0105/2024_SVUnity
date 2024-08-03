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
        // forward : z��
        // left : x��
        transform.position = transform.position + transform.forward * speed * Time.deltaTime;
    }


    //private void OnTriggerEnter(Collider other) // Collider�� Trigger�� �༮�� �浹�Ǿ��� �� �۵��ϴ� �̺�Ʈ
    //{
    //    Debug.Log($"�浹�� ��� �̸� : {other.name}");

    //    // �÷��̾ ������Ʈ�� �浹���� �� ���ӿ���
    //}

    private Vector3 originPos;

    private void OnCollisionEnter(Collision collision) // Collider �� Trigger �� false �� �� �۵��ϴ� �̺�Ʈ
    {
        if (collision.collider.CompareTag("Player")) // ��ü�� Tag �̸� �������� �´��� �ƴ��� �Ҹ��� �ڷ������� �� ����
        {
            //Destroy(gameObject); // this.gameObject �� (this ���� ����)

            // �浹�� ��� �ı�
            Destroy(collision.gameObject);
        }

        if (collision.collider.CompareTag("Wall"))
        {

            // originFos �� ������ world ��ǥ ���� 0, 0, 0 ���� �����־
            // �ڵ����� ���� �浹 �� world ��ǥ 0, 0, 0 ���� �̵���.
            transform.position = originPos;
        }
    }

    // OnTriggerEnter �� OnCollisionEnter �� ������ : Ʈ���Ŵ� ������ �浹�� �߻����� �ʴ´�. Collision ������ �浹�� �߻��ϰ� �̺�Ʈ�� �߻��Ѵ�.


    // �ڵ� �����
    private void PlayerMove()
    {
        // �÷��̾��� �Է��� �޴´�.
        float horizontalInput = Input.GetAxis("Horizontal");  
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(horizontalInput, 0, verticalInput);
    }
}
