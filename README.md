# RigidBody Component
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

# Code
 **#region (이름)** / **#endregion (이름)** <br>
region 부터 endregion 까지 그룹처리하여 해당 항목을 보이기/숨기기 할수 있다.
<br><br>
**Input.GetAxis("Vertical" / "Horizontal")** <br>
키보드와 조이스틱 입력값에 대해 -1 부터 1까지의 값 반환, 프레임에 영향을 받지 않는다.
<br><br>
**transform.변수** <br>
transform 은 오브젝트에 할당된 Transform 컴포넌트 <br>
위치, 회전, 크기를 담고 있다. <br>
변수들에 관해서는 >> https://docs.unity3d.com/kr/530/ScriptReference/Transform.html
<br><br>
