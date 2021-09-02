using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyCharacter : MonoBehaviour
{
    // #region �� #endregion �κб��� �׸����� �����Ͽ� �׸� �����/���̱� �� �Ҽ� �ֵ��� ������ִ� ���
    #region Variables   
    public float speed = 5f;        // ĳ������ ���ǵ� ����
    public float jumpHeight = 2f;   // ĳ������ �������� ����
    public float dashDistance = 5f; // ĳ������ ��ðŸ� ����

    private Rigidbody rigidbody;    // rigidbody�� ���� ���� ������

    private Vector3 inputDirection = Vector3.zero;  // ������� �Է¿� ���� ���⼺ ��� ����

    private bool isGrounded = false;                // ĳ���Ͱ� ���� �ִ��� üũ
    public LayerMask groundLayerMask;               // Raycast �� ȿ���� ���� LayerMask �� ��� (���Ҹ���)
    public float groundCheckDistance = 0.3f;        // ���� �ִ��� �˻��Ҷ� ����� �ּ� ��ġ

    #endregion Variables
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>(); // GetComponent�� ���� rigidbody �� ����
    }

    // Update is called once per frame
    void Update()
    {
        CheckGroundStatus();

        // ����� �Է� (�̵�)
        inputDirection = Vector3.zero;                  // �Է��� �޾ƿ������� �ѹ� �ʱ�ȭ
        inputDirection.x = Input.GetAxis("Horizontal"); // ��/�쿡 ���� �Է°� (-1 ~ 1 ������ ���� �����)
        inputDirection.z = Input.GetAxis("Vertical");   // ��/�ڿ� ���� �Է°� (-1 ~ 1 ������ ���� �����)

        if (inputDirection != Vector3.zero)             // ����ڰ� �Է����̶��
        {
            transform.forward = inputDirection;         // ĳ������ ������ �Է� �������� ���Ѵ�.
        }

        // ����� �Է� (����)
        if (Input.GetButtonDown("Jump") && isGrounded)                // ���� �Է½�
        {
            Vector3 jumpVelocity = Vector3.up * Mathf.Sqrt(jumpHeight * -2f * Physics.gravity.y);
                                 // ĳ������ ���� ���� * ��Ʈ(���� ���� * -2f * y���� �߷�)
            rigidbody.AddForce(jumpVelocity, ForceMode.VelocityChange);
                                 // AddForce�� ���ָ� ���������� �Էµ� jumpVelocity �� �ڵ����� �������
        }

        // ����� �Է� (�뽬)
        if (Input.GetKeyDown(KeyCode.LeftShift))                // �뽬 �Է½�
        {
            Vector3 dashVelocity = Vector3.Scale(transform.forward,
                                    dashDistance * new Vector3((Mathf.Log(1f / (Time.deltaTime * rigidbody.drag + 1)) / -Time.deltaTime),
                                    0,
                                    (Mathf.Log(1f / (Time.deltaTime * rigidbody.drag + 1)) / -Time.deltaTime)));
            rigidbody.AddForce(dashVelocity, ForceMode.VelocityChange);
        }
    }

    // ������������ �̵��� ó���Ұ� �̱� ������, FixedUpdate �� ����Ѵ�.
    // Update �� �ٸ��� �����ӿ� ������� ���������� 0.02�� �ֱ�� ����ȴ�.
    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + inputDirection * speed * Time.fixedDeltaTime);
                               // rigidbody�� ������ġ + �Է� ���� * �ӵ� * ���� FixedUpdate �Լ��� ����Ǳ������ �ð� (0.02��)
    }

    #region Helper Methods
    void CheckGroundStatus() // ĳ���Ͱ� �������� ���ִ��� üũ
    {
        RaycastHit hitInfo; // RaycastHit �� �浹�� ������Ʈ�� ������ ������

#if UNITY_EDITOR
        Debug.DrawLine(transform.position + (Vector3.up * 0.1f),
            transform.position + (Vector3.up * 0.1f) + (Vector3.down * groundCheckDistance));   // �浹�˻� Ȯ�ο�
#endif

        if (Physics.Raycast(transform.position + (Vector3.up * 0.1f),
            Vector3.down, out hitInfo, groundCheckDistance, groundLayerMask))   // ������ġ���� 0.1 ���� ���� �κп������� üũ
                                                                                // ����� ���� ���������� �߳��� �����ų� �Ҷ� ��Ȱ�� üũ�� �ϱ� �����̴�.
        {
            isGrounded = true;
        }
        else 
        {
            isGrounded = false;
        }
    }
    #endregion Helper Methods
}
