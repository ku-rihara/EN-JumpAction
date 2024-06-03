using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PullingJump : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 clickPosition;
  
    [SerializeField]
    private float jumpPower = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        Physics.gravity = new Vector3(0,-20,0);
    }

    // Update is called once per frame
    void Update()
    {
        //�m�F������폜
        if (Input.GetMouseButtonDown(0))
        {
         clickPosition=Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            //�N���b�N�������W�Ƙb�������W�̍������擾
            Vector3 dist=clickPosition-Input.mousePosition;
            //�N���b�N�ƃ����[�X���������W�Ȃ�Ζ���
            if(dist.sqrMagnitude==0 ) { return; }
            //������W�������AjumpPower���������킹���l���ړ��ʂƂ���
            rb.velocity=dist.normalized*jumpPower;
        }
    }
}
