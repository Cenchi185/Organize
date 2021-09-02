using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyCharacter : MonoBehaviour
{
    // #region 은 #endregion 부분까지 항목으로 지정하여 항목 숨기기/보이기 를 할수 있도록 만들어주는 기능
    #region Variables   
    public float speed = 5f;        // 캐릭터의 스피드 변수
    public float jumpHeight = 2f;   // 캐릭터의 점프높이 변수
    public float dashDistance = 5f; // 캐릭터의 대시거리 변수

    private Rigidbody rigidbody;    // rigidbody의 제어 권한 가져옴

    private Vector3 inputDirection = Vector3.zero;  // 사용자의 입력에 대한 방향성 계산 변수

    private bool isGrounded = false;                // 캐릭터가 땅에 있는지 체크
    public LayerMask groundLayerMask;               // Raycast 의 효율을 위해 LayerMask 를 사용 (뭔소리래)
    public float groundCheckDistance = 0.3f;        // 땅에 있는지 검사할때 사용할 최소 수치

    #endregion Variables
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>(); // GetComponent를 통해 rigidbody 를 얻어옴
    }

    // Update is called once per frame
    void Update()
    {
        CheckGroundStatus();

        // 사용자 입력 (이동)
        inputDirection = Vector3.zero;                  // 입력을 받아오기전에 한번 초기화
        inputDirection.x = Input.GetAxis("Horizontal"); // 좌/우에 대한 입력값 (-1 ~ 1 까지의 값을 출력함)
        inputDirection.z = Input.GetAxis("Vertical");   // 앞/뒤에 대한 입력값 (-1 ~ 1 까지의 값을 출력함)

        if (inputDirection != Vector3.zero)             // 사용자가 입력중이라면
        {
            transform.forward = inputDirection;         // 캐릭터의 방향을 입력 방향으로 정한다.
        }

        // 사용자 입력 (점프)
        if (Input.GetButtonDown("Jump") && isGrounded)                // 점프 입력시
        {
            Vector3 jumpVelocity = Vector3.up * Mathf.Sqrt(jumpHeight * -2f * Physics.gravity.y);
                                 // 캐릭터의 위쪽 벡터 * 루트(점프 높이 * -2f * y방향 중력)
            rigidbody.AddForce(jumpVelocity, ForceMode.VelocityChange);
                                 // AddForce를 해주면 물리엔진이 입력된 jumpVelocity 를 자동으로 계산해줌
        }

        // 사용자 입력 (대쉬)
        if (Input.GetKeyDown(KeyCode.LeftShift))                // 대쉬 입력시
        {
            Vector3 dashVelocity = Vector3.Scale(transform.forward,
                                    dashDistance * new Vector3((Mathf.Log(1f / (Time.deltaTime * rigidbody.drag + 1)) / -Time.deltaTime),
                                    0,
                                    (Mathf.Log(1f / (Time.deltaTime * rigidbody.drag + 1)) / -Time.deltaTime)));
            rigidbody.AddForce(dashVelocity, ForceMode.VelocityChange);
        }
    }

    // 물리엔진으로 이동을 처리할것 이기 때문에, FixedUpdate 를 사용한다.
    // Update 와 다르게 프레임에 관계없이 고정적으로 0.02초 주기로 실행된다.
    private void FixedUpdate()
    {
        rigidbody.MovePosition(rigidbody.position + inputDirection * speed * Time.fixedDeltaTime);
                               // rigidbody의 현재위치 + 입력 방향 * 속도 * 다음 FixedUpdate 함수가 실행되기까지의 시간 (0.02초)
    }

    #region Helper Methods
    void CheckGroundStatus() // 캐릭터가 지형위에 서있는지 체크
    {
        RaycastHit hitInfo; // RaycastHit 는 충돌된 오브젝트의 정보를 가져옴

#if UNITY_EDITOR
        Debug.DrawLine(transform.position + (Vector3.up * 0.1f),
            transform.position + (Vector3.up * 0.1f) + (Vector3.down * groundCheckDistance));   // 충돌검사 확인용
#endif

        if (Physics.Raycast(transform.position + (Vector3.up * 0.1f),
            Vector3.down, out hitInfo, groundCheckDistance, groundLayerMask))   // 현재위치보다 0.1 정도 높은 부분에서부터 체크
                                                                                // 경사진 지형 같은곳에서 발끝이 묻히거나 할때 원활한 체크를 하기 위함이다.
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
