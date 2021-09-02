using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ControllerCharacter : MonoBehaviour
{
    #region Variables
    private CharacterController characterController;    // CharactorController의 제어 권한 가져옴
    private NavMeshAgent agent;                         // NavMeshAgent 제어 권한 획득
    private Camera camera;                              // Camera 제어권한 획득

    private bool isGrounded = false;                // 캐릭터가 땅에 있는지 체크

    public LayerMask groundLayerMask;               // Raycast 의 효율을 위해 LayerMask 를 사용 (뭔소리래)
    public float groundCheckDistance = 0.3f;        // 땅에 있는지 검사할때 사용할 최소 수치

    private Vector3 calcVelocity;   // 저항력에 대한 계산을 위한 임시 클래스 변수

    #endregion Variables
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();  // GetComponent를 통해 CharacterController 를 얻어옴
        agent = GetComponent<NavMeshAgent>();                       // GetComponent를 통해 NavMeshAgent 를 가져옴
        agent.updatePosition = false;                               // agent의 이동시스템이 아닌 CharacterController 의 시스템을 사용할 것이므로 false 
        agent.updateRotation = true;                                // 캐릭터의 회전값은 NavMeshAgent 시스템에 있는것을 사용

        camera = Camera.main;                                       // 메인 카메라를 얻어옴
    }

    // Update is called once per frame
    void Update()
    {
        // 사용자 마우스 좌클릭 입력
        if (Input.GetMouseButtonDown(0))
        {
            // 카메라가 보는 화면에서의 좌표 선택지점을 가져와야 하기 때문에 ScreenPointToRay 함수 사용
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            // 마우스 클릭 지점이 Raycast가 가능한지 확인
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100, groundLayerMask))
            {
                Debug.Log("We hit " + hit.collider.name + " " + hit.point); // 찍힌 지점 확인

                // hit 값이 있을때 캐릭터의 움직임
                agent.SetDestination(hit.point); // hit 한 지점으로 움직임
            }

            if (agent.remainingDistance > agent.stoppingDistance)   // remainingDistance = 도착 지점과 현재 agent(캐릭터)의 위치
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
        transform.position = agent.nextPosition; // agent의 이동방향으로 캐릭터가 바라보게 함
    }
}
