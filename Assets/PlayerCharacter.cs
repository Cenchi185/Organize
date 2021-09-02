using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class PlayerCharacter : MonoBehaviour
{
    #region Variables

    private CharacterController controller;         // Character Controller �� ������� ȹ��
    [SerializeField]
    private LayerMask groundLayerMask;              // ���� ĳ��Ʈ�� ����Ҷ� Ư�� ���̾�� �΋H������ �����ϱ� ���� ���

    private NavMeshAgent agent;                     // NavMeshAgent �� �������
    private Camera camera;                          // ī�޶��� �������

                                                    // �ܺ� ��ũ��Ʈ���� ������ ���ϵ���, ������ �ʿ� ���� ������ �������� ���ϵ��� �ϱ� ���� ���
    [SerializeField]                                // ����Ƽ ��ü���� �ν����ͷ� ������ ����������, �ܺν�ũ��Ʈ�κ��ʹ� �������� ���ϰ� ���´�.
                                                    // �ν����Ϳ��� ���� ������ ���� �ִ� private ������ ���� ���ȴ�.
    private Animator animator;                      // �ִϸ������� �������

    readonly int moveHash = Animator.StringToHash("Move");          // readonly �� ����� ������ �ʱ�ȭ ���� ���� ������ �Ұ����ϴ�. �����ڿ��� ���� ������
    readonly int fallingHash = Animator.StringToHash("Falling");    // StringToHash �� �ִϸ��̼� ��Ʈ�ѷ����� ������ �Ķ���Ϳ� �����Ҽ� �ֵ��� ���ִ� Animator �� Ŭ����
    #endregion

    #region Main Methods

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();       // CharacterController�� ������Ʈ ����

        agent = GetComponent<NavMeshAgent>();                   // NavMeshAgent�� ������Ʈ ����
        agent.updatePosition = false;                           // NavMeshAgent�� �̵� �ý����� ������� ����
        agent.updateRotation = true;                            // NavMeshAgent�� ȸ�� �ý��� ��� (ĳ���Ͱ� �ٶ󺸴� ����)

        camera = Camera.main;                                   // ���� ī�޶� ���
    }

    // Update is called once per frame
    void Update()
    {

        // Process mouse left button input
        if (Input.GetMouseButtonDown(0))                            // ��Ŭ����
        {
            // Make ray from screen to world
            Ray ray = camera.ScreenPointToRay(Input.mousePosition); // ScreenPointToRay �� ī�޶�� �����ִ� ȭ�鿡���� ��ǥ������ ������ ��

            // Check hit from ray
            RaycastHit hit;                                         // Ray�� Hit �ߴ��� �˻�
            if (Physics.Raycast(ray, out hit, 100, groundLayerMask))// Raycast�� �������� ������ �������� ������ ��µ�, �浹�Ǹ� True �� ��ȯ��
            {                                                       // Physics.Raycast(������, ����, �ִ� �Ÿ�, ���̾��ũ ���͸�) ��ȯ ���� RaycastHit�� �Ѱ���
                Debug.Log("We hit " + hit.collider.name + " " + hit.point); // ray �� ���� ���� ���

                // Move our player to what we hit
                agent.SetDestination(hit.point);    // NavMeshAgent �� ����� �̿��Ͽ� hit �������� �̵���
            }
        }

        if (agent.remainingDistance > agent.stoppingDistance)   // ���� �Ÿ��� �����Ÿ����� ���
        {
            controller.Move(agent.velocity * Time.deltaTime);   // ChatracterController �� Move ����� �̿��Ͽ� �̵�
            animator.SetBool(moveHash, true);                   // Animator�� moveHash �Ķ���͸� True �� �ٲپ� �ִϸ��̼� ���
        }
        else
        {
            controller.Move(Vector3.zero);                      // ���� ������ Move �� Vector ���� 0�� ����� ����
            animator.SetBool(moveHash, false);                  // moveHash �Ķ���͸� False �� �ٲپ� �ִϸ��̼� ����
        }
/*
        if (agent.isOnOffMeshLink)                              // ĳ���Ͱ� OffMeshLink ���� ��ġ�ߴ��� Ȯ��
        {
            animator.SetBool(fallingHash, agent.velocity.y != 0.0f);
        }
        else
        {
            animator.SetBool(fallingHash, false);
        }
*/
    }

    private void OnAnimatorMove()
    {
        Vector3 position = agent.nextPosition;          // ĳ���Ͱ� �̵��Ҷ� �����̴� ������ ����
        animator.rootPosition = agent.nextPosition;
        transform.position = position;                  // transform �� ����Ͽ� �����̴� ������ ������ position ����
    }
    #endregion Main Methods

    #region Helper Methods
    #endregion Helper Methods
}
