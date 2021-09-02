using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class PlayerCharacter : MonoBehaviour
{
    #region Variables

    private CharacterController controller;         // Character Controller 의 제어권한 획득
    [SerializeField]
    private LayerMask groundLayerMask;              // 레이 캐스트를 사용할때 특정 레이어에만 부딫히도록 설정하기 위해 사용

    private NavMeshAgent agent;                     // NavMeshAgent 의 제어권한
    private Camera camera;                          // 카메라의 제어권한

                                                    // 외부 스크립트에서 수정을 못하도록, 참조할 필요 없는 변수에 접근하지 못하도록 하기 위해 사용
    [SerializeField]                                // 유니티 자체에서 인스펙터로 접근은 가능하지만, 외부스크립트로부터는 접근하지 못하게 막는다.
                                                    // 인스펙터에서 자주 변경할 일이 있는 private 변수에 자주 사용된다.
    private Animator animator;                      // 애니메이터의 제어권한

    readonly int moveHash = Animator.StringToHash("Move");          // readonly 로 선언된 변수는 초기화 이후 값이 변경이 불가능하다. 생성자에서 값이 결정됨
    readonly int fallingHash = Animator.StringToHash("Falling");    // StringToHash 는 애니메이션 컨트롤러에서 설정한 파라미터에 접근할수 있도록 해주는 Animator 의 클래스
    #endregion

    #region Main Methods

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();       // CharacterController의 컴포넌트 얻어옴

        agent = GetComponent<NavMeshAgent>();                   // NavMeshAgent의 컴포넌트 얻어옴
        agent.updatePosition = false;                           // NavMeshAgent의 이동 시스템을 사용하지 않음
        agent.updateRotation = true;                            // NavMeshAgent의 회전 시스템 사용 (캐릭터가 바라보는 방향)

        camera = Camera.main;                                   // 메인 카메라 사용
    }

    // Update is called once per frame
    void Update()
    {

        // Process mouse left button input
        if (Input.GetMouseButtonDown(0))                            // 좌클릭시
        {
            // Make ray from screen to world
            Ray ray = camera.ScreenPointToRay(Input.mousePosition); // ScreenPointToRay 는 카메라로 보고있는 화면에서의 좌표지점을 가지고 옴

            // Check hit from ray
            RaycastHit hit;                                         // Ray가 Hit 했는지 검사
            if (Physics.Raycast(ray, out hit, 100, groundLayerMask))// Raycast는 시작점과 지정된 방향으로 광선을 쏘는데, 충돌되면 True 를 반환함
            {                                                       // Physics.Raycast(시작점, 방향, 최대 거리, 레이어마스크 필터링) 반환 값은 RaycastHit로 넘겨줌
                Debug.Log("We hit " + hit.collider.name + " " + hit.point); // ray 가 찍힌 지점 출력

                // Move our player to what we hit
                agent.SetDestination(hit.point);    // NavMeshAgent 의 기능을 이용하여 hit 지점으로 이동함
            }
        }

        if (agent.remainingDistance > agent.stoppingDistance)   // 남은 거리가 제동거리보다 길면
        {
            controller.Move(agent.velocity * Time.deltaTime);   // ChatracterController 의 Move 기능을 이용하여 이동
            animator.SetBool(moveHash, true);                   // Animator의 moveHash 파라미터를 True 로 바꾸어 애니메이션 출력
        }
        else
        {
            controller.Move(Vector3.zero);                      // 길지 않으면 Move 의 Vector 값을 0로 만들어 멈춤
            animator.SetBool(moveHash, false);                  // moveHash 파라미터를 False 로 바꾸어 애니메이션 멈춤
        }
/*
        if (agent.isOnOffMeshLink)                              // 캐릭터가 OffMeshLink 위에 위치했는지 확인
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
        Vector3 position = agent.nextPosition;          // 캐릭터가 이동할때 움직이는 방향을 설정
        animator.rootPosition = agent.nextPosition;
        transform.position = position;                  // transform 을 사용하여 움직이는 방향을 보도록 position 설정
    }
    #endregion Main Methods

    #region Helper Methods
    #endregion Helper Methods
}
