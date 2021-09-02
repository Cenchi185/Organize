# 학습 내용 총정리 목차
너무 길어지면 추후 제작 예정

# RigidBody Component
<details mardown="1">
  <summary> RigidBody Component 보기 </summary>
  
| 컴포넌트 명 | 설명 |
|---|---|
|Mass| 질량을 설정, 중력에는 영향이 없다. Rigidbody 끼리의 충돌시에 사용됨 |
|Drag| 공기저항 값, 작을수록 무거워보이고, 클수록 가볍게 보인다. |
|Angular Drag| 회전시에 받는 공기저항 값|
|Use Gravity| 중력을 받을것인지 체크|
|Is Kenematic| 물리엔진이 아닌 게임 오브젝트 로직에 따라 오브젝트를 움직일 것인가|
|Interpolate| ???|
|Collision Detection| 충돌 처리에 관한 값| 
|Freeze Position/Rotation x,y,z| 물리엔진에서 처리할 값을 무시하도록 할것인지 | 
  
  </details>

# Character Controller Component
<details mardown="1">
  <summary> Character Controller Component 보기 </summary>
  
|컴포넌트 명|설명|
|---|---|
|Slope Limit|캐릭터가 오를 수 있는 최대 경사|
|Step Offset|캐릭터가 계단을 오를수 있는 계단의 높이 간격|
|Skin Width|다른 콜라이더와 부딫혔을 때 겹칠수 있는 정도
|Min Move Distance|캐릭터가 이동할 수 있는 최소 값, 이 값 미만으로는 움직이지 않는다.|
  
  </details>

# NavMeshAgent Component
<details mardown="1">
  <summary> NavMeshAgent Component 보기 </summary>
  
|컴포넌트 명|설명|
|---|---|
|Agent Type|Agent 개체의 특징 설정|
|Base Offset|NavMeshAgent 의 높낮이를 조절|
|Speed|이동할때 속도|
|Angular Speed|방향을 돌릴때의 속도|
|Acceleration| 이동할때의 가속도|
|Stoopping Distance| 제동거리|
|Auto Breaking| 지점에 도착했을때 자동으로 멈추기|
|Radious/Height| 물체를 회피할때 물체에서 떨어진 정도 |
|Quaility| 장애물을 회피할때의 정밀도|
|Priority| Agent간의 회피 우선순위|
|Auto Traverse Off Mesh Link| 분리된 메쉬간 자동으로 링크를 생성하는 옵션
|Auto Repath| 경로가 유효하지 않을때 재탐색 여부|
|Area Mask| 길찾기를 사용할 레이어 결정|
  
</details>

# 1강 Code
<details mardown="1">
  <summary> 1강 Code 정리 보기 </summary>
  
```C#
#region (이름)
#endregion (이름)
```
region 부터 endregion 까지 그룹처리하여 해당 항목을 보이기/숨기기 할수 있다.
<br><br>
~~~C#
Input.GetAxis("Vertical" / "Horizontal")
Input.GetAxisRaw("Vertical" / "Horizontal")
~~~
키보드와 조이스틱 입력값에 대해 -1 부터 1사이의 값 반환, 프레임에 영향을 받지 않는다. <br>
앞,뒤는 Vertical, 왼쪽 오른쪽은 Horizontal
<br><br>
```C#
transform.Variables
```
transform 은 오브젝트에 할당된 Transform 컴포넌트 <br>
위치, 회전, 크기를 담고 있다. <br>
변수(Variables)들에 관해서는 >> https://docs.unity3d.com/kr/530/ScriptReference/Transform.html
<br><br>
```C#
FixedUpdate()
```
Update 와 달리 일정한 간격으로 호출된다. 물리효과가 적용된 오브젝트를 조정할때 사용한다. <br>
Update 는 불규칙적으로 호출 될 수 있으므로 물리엔진 충돌 검사등이 제대로 되지 않을 수 있기 때문
<br><br>
```C#
Time.Deltatime()
Time.FixedDeltaTime()
```
한 프레임이 재생 완료되기까지 걸리는 시간 <br>
FixedDeltaTime 은 0.02초 이다.
<br><br>
```C#
Input.GetButtonDown("Variables")
Input.GetKeyDown(KeyCodes.Variables)
```
GetButtonDown 은 유니티 내에 InputManager를 통해 설정된 입력키를 사용한다. (Edit > Project Setting > Input) <br>
GetKeyDown 은 키보드에 해당하는 버튼을 누를때 값을 반환한다. <br>
GetKeyDown 의 변수들 >> https://docs.unity3d.com/kr/530/ScriptReference/KeyCode.html
<br><br>
```C#
Input.GetKeyDown(KeyCode.Variabels)
Input.GetKey(KeyCode.Variables)
Input.GeyKeyUp(KeyCode.Variables)
```
KeyDown 은 눌렀을때, Key 는 누르고 있을때, KeyUp 은 눌렀다가 뗐을때 값을 반환한다. <br> 
Button 의 경우도 동일하다.
<br><br>
```C#
LayerMask Variables
```
레이어 마스크는 RayCast 를 사용한 계산을 할때 Ray 가 특정 오브젝트에만 충돌 반응 할수 있도록 하여 <br>
연산 효율을 높이기 위해 사용됨
<br><br>
```C#
RaycastHit Variable
```
레이캐스트를 통해 발사된 Ray가 충돌된 오브젝트의 정보를 변수에 담아 가지고 온다.
<br><br>
```C#
Physics.Raycast(시작점, 방향, 충돌 정보 반환, 발사최대거리, 레이어마스크 필터링)  
```
Ray 를 발사하는 시작점과 방향을 지정해서 받은 충돌 정보를 어디로 넘길 것인지에 대한 코드 <br>
발사 최대 거리와 레이어마스크를 통해 특정 레이어에만 충돌하도록 필터링 할 수 있다. <br>
시작점을 캐릭터의 발끝보다 살짝 위로 지정하면 경사진 면을 오를때 발이 묻히거나 할 경우에도 원활한 체크가 가능하다.
<br><br>
```C#

```
<br><br>
<br><br>
<br><br>
<br><br>
<br><br>
  
  </details>
  
# 학습중 발생한 버그
<details mardown="1">
  <summary> Character Controller 실습 중 점프 버그 </summary>

 ![GIF](https://user-images.githubusercontent.com/80375744/131792202-925c0b4f-fc08-475f-b45d-67914f36b2d6.gif)
<br>
Chracter Controller 를 통해 캐릭터를 조종 하는중 발생한 문제이다. <br>
캐릭터의 점프가 원활하지 않아 캐릭터가 땅에 있는지 체크하는 변수 isGrounded 의 값을 체크해 보았는데 <br>
분명히 땅을 밟고 있음에도 false 를 출력하다가 아주 가끔 True 가 되면서 점프가 버벅이는 문제점이다. <br>

## 사용 코드
  <details mardown="1">
  <summary> 사용한 코드 보기 </summary>
  
```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerChracter_Bug : MonoBehaviour
{
    #region Variables
    public float speed = 5f;            // 이동속도
    public float jumpHeight = 4f;       // 점프 높이
    public float dashDistance = 5f;     // 대쉬 거리
    public float gravity = -9.81f;      // 중력

    private bool isGrounded;     // 캐릭터가 땅에 서있는지 아닌지 체크 여부

    public Vector3 drags;               // 공기저항
    public LayerMask groundLayerMask;   // 캐릭터와 충돌할 레이어 설정

    private CharacterController characterController;    // 제어권한 획득을 위한 변수 선언
    private Vector3 calcVelocity;       // 캐릭터의 벡터 계산 값을 담아둘 임시 변수

    #endregion Variables
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        calcVelocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = characterController.isGrounded; // CharacterController 에 있는 isGrounded 변수 사용

        if (isGrounded && calcVelocity.y < 0)   // 땅위에 서있을때
        {
            calcVelocity.y = 0;     // y축 방향의 저항력을 없앰
        }

        // 캐릭터 이동
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));  // 캐릭터의 이동 방향 받아오기
        characterController.Move(move * Time.deltaTime * speed);    // 게임 실행시 보이는 캐릭터 이동시키기

        if (move != Vector3.zero)   // 캐릭터가 이동중이면
        {
            transform.forward = move;   // 해당 방향을 보도록 함
        }

        // 점프
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)  // 땅에 있을때 점프를 누르면
        {
            calcVelocity.y += Mathf.Sqrt(jumpHeight * -2f * Physics.gravity.y); // 점프
        }

        // 대쉬
        if (Input.GetKeyDown(KeyCode.LeftShift))    // 대쉬 버튼을 누르면
        { 
            Vector3 dashVelocity = Vector3.Scale(transform.forward,
                                    dashDistance * new Vector3((Mathf.Log(1f / (Time.deltaTime * drags.x + 1)) / -Time.deltaTime),
                                    0,
                                    (Mathf.Log(1f / (Time.deltaTime * drags.z + 1)) / -Time.deltaTime)));   // 대쉬
            calcVelocity += dashVelocity;   // 캐릭터에 적용될 벡터 값 추가
        }

        // 중력 계산
        calcVelocity.y += gravity * Time.deltaTime;

        // 공기저항 계산
        calcVelocity.x /= 1 + drags.x * Time.deltaTime;
        calcVelocity.y /= 1 + drags.y * Time.deltaTime;
        calcVelocity.z /= 1 + drags.z * Time.deltaTime;

        characterController.Move(calcVelocity * Time.deltaTime);    // 중력과 공기저항을 이동시에 더함
    }
}
```
<br>
    </details>
<br>
    
<details mardown="1">
<summary> 문제 해결을 위해 찾아본 정보 </summary>
      
![GIF2](https://user-images.githubusercontent.com/80375744/131794661-63cec765-858c-416b-9c1c-2ea8ce8b8603.gif)
문제 해결을 위해 calcVelocity.y 의 값이 잘못되어 그런게 아닐까 싶어 Debug 를 활용해 수치를 확인해보았더니 <br>
isGrounded 라는 변수는 calcVelocity.y 의 값이 정확히 0 일때만 True 를 반환하지만 <br>
현재 캐릭터의 y좌표값이 미세하게 0 이하로 떨어져있어서 자꾸만 false 를 반환하는 것 같다.
<br><br>
https://tech.lonpeach.com/2019/09/15/UniRx-Example-IsGrounded/ <br>
구글에 검색해보니, isGrounded 자체의 접지 판정 정밀도가 굉장히 별로라고 한다. <br>
그래서 Raycast 와 병행하여 판정한다고 하는데, 나름대로 노력해보았지만 <br>
지금 내 지식 수준으로 Raycast 를 활용하기는 힘들어서 고치지 못했다.
<br><br>
현재 제작하고자 하는 게임의 목표는 탑다운 뷰 형식의 RPG 게임제작이 목표이므로 <br>
탑다운 뷰 형식의 게임들에서는 점프가 없는 경우도 있기 때문에, 현재 중요하게 다뤄야할 문제는 아니라 생각하여 일단 넘기기로 했다.
        
</details>
        
</details>
