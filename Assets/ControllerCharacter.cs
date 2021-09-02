using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControllerCharacter : MonoBehaviour
{
    #region Variables
    private CharacterController characterController;    // CharactorController�� ���� ���� ������
    private NavMeshAgent agent;                         // NavMeshAgent ���� ���� ȹ��
    private Camera camera;                              // Camera ������� ȹ��

    private bool isGrounded = false;                // ĳ���Ͱ� ���� �ִ��� üũ

    public LayerMask groundLayerMask;               // Raycast �� ȿ���� ���� LayerMask �� ��� (���Ҹ���)
    public float groundCheckDistance = 0.3f;        // ���� �ִ��� �˻��Ҷ� ����� �ּ� ��ġ

    private Vector3 calcVelocity;   // ���׷¿� ���� ����� ���� �ӽ� Ŭ���� ����

    #endregion Variables
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();  // GetComponent�� ���� CharacterController �� ����
        agent = GetComponent<NavMeshAgent>();                       // GetComponent�� ���� NavMeshAgent �� ������
        agent.updatePosition = false;                               // agent�� �̵��ý����� �ƴ� CharacterController �� �ý����� ����� ���̹Ƿ� false 
        agent.updateRotation = true;                                // ĳ������ ȸ������ NavMeshAgent �ý��ۿ� �ִ°��� ���

        camera = Camera.main;                                       // ���� ī�޶� ����
    }

    // Update is called once per frame
    void Update()
    {
        // ����� ���콺 ��Ŭ�� �Է�
        if (Input.GetMouseButtonDown(0))
        {
            // ī�޶� ���� ȭ�鿡���� ��ǥ ���������� �����;� �ϱ� ������ ScreenPointToRay �Լ� ���
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            // ���콺 Ŭ�� ������ Raycast�� �������� Ȯ��
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100, groundLayerMask))
            {
                Debug.Log("We hit " + hit.collider.name + " " + hit.point); // ���� ���� Ȯ��

                // hit ���� ������ ĳ������ ������
                agent.SetDestination(hit.point); // hit �� �������� ������
            }

            if (agent.remainingDistance > agent.stoppingDistance)   // remainingDistance = ���� ������ ���� agent(ĳ����)�� ��ġ
            {
                characterController.Move(agent.velocity * Time.deltaTime);
            }
            else
            {
                characterController.Move(Vector3.zero);
            }
        }
    }

    private void LateUpdate()
    {
        transform.position = agent.nextPosition; // agent�� �̵��������� ĳ���Ͱ� �ٶ󺸰� ��
    }
}
