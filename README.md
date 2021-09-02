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
