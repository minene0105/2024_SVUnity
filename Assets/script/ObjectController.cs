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
    }

    // Update is called once per frame
    void Update()
    {
        // forward : z��
        // left : x��
        transform.position = transform.position + transform.forward * speed * Time.deltaTime;
    }

    



    // �ڵ� �����
    private void PlayerMove()
    {
        // �÷��̾��� �Է��� �޴´�.
        float horizontalInput = Input.GetAxis("Horizontal");  
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(horizontalInput, 0, verticalInput);
    }
}
