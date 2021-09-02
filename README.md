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

# 1강 Code
```C#
#region (이름)
#endregion (이름)
```
region 부터 endregion 까지 그룹처리하여 해당 항목을 보이기/숨기기 할수 있다.
<br><br>
~~~C#
Input.GetAxis("Vertical" / "Horizontal")
~~~
키보드와 조이스틱 입력값에 대해 -1 부터 1까지의 값 반환, 프레임에 영향을 받지 않는다.
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
GetKeyDown 의 변수들 >> https://docs.unity3d.com/kr/530/ScriptReference/KeyCode.html <br>

<br><br>
```C#
Input.GetKeyDown(KeyCode.Variabels)
Input.GetKey(KeyCode.Variables)
Input.GeyKeyUp(KeyCode.Variables)
```
KeyDown 은 눌렀을때, Key 는 누르고 있을때, KeyUp 은 눌렀다가 뗐을때 값을 반환한다. <br> 
Button 의 경우도 동일하다.
<br><br>

<br><br>

<br><br>

<br><br>
<br><br>
<br><br>
<br><br>
<br><br>
<br><br>
