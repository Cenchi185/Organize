๐ซ๐ซ๐ซ **๊ฐ์๋ฅผ ๋ฃ๊ณ  ์ดํดํ ๋ด์ฉ๋๋ก ์ ๋ฆฌํ ๊ฒ์ด๋ฏ๋ก, ์ ํํ ์ค๋ช์ด ์๋ ์ ์์** ๐ซ๐ซ๐ซ <br>

---

# ํ์ต ๋ด์ฉ ์ด์ ๋ฆฌ ๋ชฉ์ฐจ
๋๋ฌด ๊ธธ์ด์ง๋ฉด ์ถํ ์ ์ ์์ 

<details mardown="1">
  <summary> Component ๋ณด๊ธฐ </summary>

# RigidBody Component
<details mardown="1">
  <summary> RigidBody Component ๋ณด๊ธฐ </summary>
  
| ์ปดํฌ๋ํธ ๋ช | ์ค๋ช |
|---|---|
|Mass| ์ง๋์ ์ค์ , ์ค๋ ฅ์๋ ์ํฅ์ด ์๋ค. Rigidbody ๋ผ๋ฆฌ์ ์ถฉ๋์์ ์ฌ์ฉ๋จ |
|Drag| ๊ณต๊ธฐ์ ํญ ๊ฐ, ์์์๋ก ๋ฌด๊ฑฐ์๋ณด์ด๊ณ , ํด์๋ก ๊ฐ๋ณ๊ฒ ๋ณด์ธ๋ค. |
|Angular Drag| ํ์ ์์ ๋ฐ๋ ๊ณต๊ธฐ์ ํญ ๊ฐ|
|Use Gravity| ์ค๋ ฅ์ ๋ฐ์๊ฒ์ธ์ง ์ฒดํฌ|
|Is Kenematic| ๋ฌผ๋ฆฌ์์ง์ด ์๋ ๊ฒ์ ์ค๋ธ์ ํธ ๋ก์ง์ ๋ฐ๋ผ ์ค๋ธ์ ํธ๋ฅผ ์์ง์ผ ๊ฒ์ธ๊ฐ|
|Interpolate| ???|
|Collision Detection| ์ถฉ๋ ์ฒ๋ฆฌ์ ๊ดํ ๊ฐ| 
|Freeze Position/Rotation x,y,z| ๋ฌผ๋ฆฌ์์ง์์ ์ฒ๋ฆฌํ  ๊ฐ์ ๋ฌด์ํ๋๋ก ํ ๊ฒ์ธ์ง | 
  
  </details>

# Character Controller Component
<details mardown="1">
  <summary> Character Controller Component ๋ณด๊ธฐ </summary>
  
|์ปดํฌ๋ํธ ๋ช|์ค๋ช|
|---|---|
|Slope Limit|์บ๋ฆญํฐ๊ฐ ์ค๋ฅผ ์ ์๋ ์ต๋ ๊ฒฝ์ฌ|
|Step Offset|์บ๋ฆญํฐ๊ฐ ๊ณ๋จ์ ์ค๋ฅผ์ ์๋ ๊ณ๋จ์ ๋์ด ๊ฐ๊ฒฉ|
|Skin Width|๋ค๋ฅธ ์ฝ๋ผ์ด๋์ ๋ถ๋ซํ์ ๋ ๊ฒน์น ์ ์๋ ์ ๋
|Min Move Distance|์บ๋ฆญํฐ๊ฐ ์ด๋ํ  ์ ์๋ ์ต์ ๊ฐ, ์ด ๊ฐ ๋ฏธ๋ง์ผ๋ก๋ ์์ง์ด์ง ์๋๋ค.|
  
  </details>

# NavMeshAgent Component
<details mardown="1">
  <summary> NavMeshAgent Component ๋ณด๊ธฐ </summary>
  
|์ปดํฌ๋ํธ ๋ช|์ค๋ช|
|---|---|
|Agent Type|Agent ๊ฐ์ฒด์ ํน์ง ์ค์ |
|Base Offset|NavMeshAgent ์ ๋๋ฎ์ด๋ฅผ ์กฐ์ |
|Speed|์ด๋ํ ๋ ์๋|
|Angular Speed|๋ฐฉํฅ์ ๋๋ฆด๋์ ์๋|
|Acceleration| ์ด๋ํ ๋์ ๊ฐ์๋|
|Stoopping Distance| ์ ๋๊ฑฐ๋ฆฌ|
|Auto Breaking| ์ง์ ์ ๋์ฐฉํ์๋ ์๋์ผ๋ก ๋ฉ์ถ๊ธฐ|
|Radious/Height| ๋ฌผ์ฒด๋ฅผ ํํผํ ๋ ๋ฌผ์ฒด์์ ๋จ์ด์ง ์ ๋ |
|Quaility| ์ฅ์ ๋ฌผ์ ํํผํ ๋์ ์ ๋ฐ๋|
|Priority| Agent๊ฐ์ ํํผ ์ฐ์ ์์|
|Auto Traverse Off Mesh Link| ๋ถ๋ฆฌ๋ ๋ฉ์ฌ๊ฐ ์๋์ผ๋ก ๋งํฌ๋ฅผ ์์ฑํ๋ ์ต์
|Auto Repath| ๊ฒฝ๋ก๊ฐ ์ ํจํ์ง ์์๋ ์ฌํ์ ์ฌ๋ถ|
|Area Mask| ๊ธธ์ฐพ๊ธฐ๋ฅผ ์ฌ์ฉํ  ๋ ์ด์ด ๊ฒฐ์ |

  </details>
  
  # Light Mode
  <details mardown="1">
  <summary> Light Mode ๋ณด๊ธฐ </summary>
    
|์ปดํฌ๋ํธ ๋ช|์ค๋ช|
|---|---|
|RealTime|๋ชจ๋  ์ค๋ธ์ ํธ์ ๊ด์ํจ๊ณผ๋ฅผ ์ฃผ๊ณ , ๊ทธ๋ฆผ์ ์์ฑ๊ฐ์ ๋ฐ๋ผ ๊ทธ๋ฆผ์๋ฅผ ์์ฑ|
|Mixed|์ ์ ์ธ ์ค๋ธ์ ํธ๋ ๋ผ์ดํธ๋งคํ ๊ธฐ๋ฒ ์ฌ์ฉ, ๋์ ์ธ ์ค๋ธ์ ํธ๋ ์ค์๊ฐ์ผ๋ก ๊ณ์ฐ|
|Baked|์์ง์ด๋ ์ค๋ธ์ ํธ์๋ ์ํฅ์ด ์๊ณ , ์ ์ ์ธ ์ค๋ธ์ ํธ ๊ด์ ํจ๊ณผ๋ง ๊ณ์ฐ|
  
  </details>
  
  # Lighting Component
  <details mardown="1">
  <summary> Lighting Component ๋ณด๊ธฐ </summary>
    
Window - Rendering - LightSettings

|์ปดํฌ๋ํธ ๋ช|์ค๋ช|
|---|---|
|SkyBox Material|ํ๋, ๋ฐฐ๊ฒฝ๊ฐ์ ๊ฒ๋ค์ ํํํ๋ SkyBox ์ ํ์ค์ณ |
|Sun Source|ํ์ค๋ก ์น์๋ฉด "ํ์" ์ ์ํ๋ ๊ด์ํจ๊ณผ๋ฅผ ์ง์ ํ๋ ๊ฒ|
|Realtime Global Ilumination|๊ด์ํจ๊ณผ๋ฅผ ์ค์๊ฐ์ผ๋ก ๊ณ์ฐํ  ๊ฒ์ธ์ง ์ฒดํฌ, ์ฐ์ฐ์ ๋ถํ๊ฐ ํฌ๋ค.|
|Lightmapping Settings|๋ผ์ดํธ ๋งคํ ๊ธฐ๋ฒ์ ๋ํ ์ค์ ๊ฐ๋ค https://docs.unity3d.com/kr/2018.4/Manual/GlobalIllumination.html|
    
  </details>
  
</details>

# 1๊ฐ Code
<details mardown="1">
  <summary> 1๊ฐ Code ์ ๋ฆฌ ๋ณด๊ธฐ </summary>
  
```C#
#region (์ด๋ฆ)
#endregion (์ด๋ฆ)
```
region ๋ถํฐ endregion ๊น์ง ๊ทธ๋ฃน์ฒ๋ฆฌํ์ฌ ํด๋น ํญ๋ชฉ์ ๋ณด์ด๊ธฐ/์จ๊ธฐ๊ธฐ ํ ์ ์๋ค.
<br><br>
~~~C#
Input.GetAxis("Vertical" / "Horizontal")
Input.GetAxisRaw("Vertical" / "Horizontal")
~~~
ํค๋ณด๋์ ์กฐ์ด์คํฑ ์๋ ฅ๊ฐ์ ๋ํด -1 ๋ถํฐ 1์ฌ์ด์ ๊ฐ ๋ฐํ, ํ๋ ์์ ์ํฅ์ ๋ฐ์ง ์๋๋ค. <br>
์,๋ค๋ Vertical, ์ผ์ชฝ ์ค๋ฅธ์ชฝ์ Horizontal
<br><br>
```C#
transform.Variables
```
transform ์ ์ค๋ธ์ ํธ์ ํ ๋น๋ Transform ์ปดํฌ๋ํธ <br>
์์น, ํ์ , ํฌ๊ธฐ๋ฅผ ๋ด๊ณ  ์๋ค. <br>
๋ณ์(Variables)๋ค์ ๊ดํด์๋ >> https://docs.unity3d.com/kr/530/ScriptReference/Transform.html
<br><br>
```C#
FixedUpdate()
```
Update ์ ๋ฌ๋ฆฌ ์ผ์ ํ ๊ฐ๊ฒฉ์ผ๋ก ํธ์ถ๋๋ค. ๋ฌผ๋ฆฌํจ๊ณผ๊ฐ ์ ์ฉ๋ ์ค๋ธ์ ํธ๋ฅผ ์กฐ์ ํ ๋ ์ฌ์ฉํ๋ค. <br>
Update ๋ ๋ถ๊ท์น์ ์ผ๋ก ํธ์ถ ๋  ์ ์์ผ๋ฏ๋ก ๋ฌผ๋ฆฌ์์ง ์ถฉ๋ ๊ฒ์ฌ๋ฑ์ด ์ ๋๋ก ๋์ง ์์ ์ ์๊ธฐ ๋๋ฌธ
<br><br>
```C#
Time.Deltatime()
Time.FixedDeltaTime()
```
ํ ํ๋ ์์ด ์ฌ์ ์๋ฃ๋๊ธฐ๊น์ง ๊ฑธ๋ฆฌ๋ ์๊ฐ <br>
FixedDeltaTime ์ 0.02์ด ์ด๋ค.
<br><br>
```C#
Input.GetButtonDown("Variables")
Input.GetKeyDown(KeyCodes.Variables)
```
GetButtonDown ์ ์ ๋ํฐ ๋ด์ InputManager๋ฅผ ํตํด ์ค์ ๋ ์๋ ฅํค๋ฅผ ์ฌ์ฉํ๋ค. (Edit > Project Setting > Input) <br>
GetKeyDown ์ ํค๋ณด๋์ ํด๋นํ๋ ๋ฒํผ์ ๋๋ฅผ๋ ๊ฐ์ ๋ฐํํ๋ค. <br>
GetKeyDown ์ ๋ณ์๋ค >> https://docs.unity3d.com/kr/530/ScriptReference/KeyCode.html
<br><br>
```C#
Input.GetKeyDown(KeyCode.Variabels)
Input.GetKey(KeyCode.Variables)
Input.GeyKeyUp(KeyCode.Variables)
```
KeyDown ์ ๋๋ ์๋, Key ๋ ๋๋ฅด๊ณ  ์์๋, KeyUp ์ ๋๋ ๋ค๊ฐ ๋์๋ ๊ฐ์ ๋ฐํํ๋ค. <br> 
Button ์ ๊ฒฝ์ฐ๋ ๋์ผํ๋ค.
<br><br>
```C#
LayerMask Variables
```
๋ ์ด์ด ๋ง์คํฌ๋ RayCast ๋ฅผ ์ฌ์ฉํ ๊ณ์ฐ์ ํ ๋ Ray ๊ฐ ํน์  ์ค๋ธ์ ํธ์๋ง ์ถฉ๋ ๋ฐ์ ํ ์ ์๋๋ก ํ์ฌ <br>
์ฐ์ฐ ํจ์จ์ ๋์ด๊ธฐ ์ํด ์ฌ์ฉ๋จ
<br><br>
```C#
RaycastHit Variable
```
๋ ์ด์บ์คํธ๋ฅผ ํตํด ๋ฐ์ฌ๋ Ray๊ฐ ์ถฉ๋๋ ์ค๋ธ์ ํธ์ ์ ๋ณด๋ฅผ ๋ณ์์ ๋ด์ ๊ฐ์ง๊ณ  ์จ๋ค.
<br><br>
```C#
Physics.Raycast(์์์ , ๋ฐฉํฅ, ์ถฉ๋ ์ ๋ณด ๋ฐํ, ๋ฐ์ฌ์ต๋๊ฑฐ๋ฆฌ, ๋ ์ด์ด๋ง์คํฌ ํํฐ๋ง)  
```
Ray ๋ฅผ ๋ฐ์ฌํ๋ ์์์ ๊ณผ ๋ฐฉํฅ์ ์ง์ ํด์ ๋ฐ์ ์ถฉ๋ ์ ๋ณด๋ฅผ ์ด๋๋ก ๋๊ธธ ๊ฒ์ธ์ง์ ๋ํ ์ฝ๋ <br>
๋ฐ์ฌ ์ต๋ ๊ฑฐ๋ฆฌ์ ๋ ์ด์ด๋ง์คํฌ๋ฅผ ํตํด ํน์  ๋ ์ด์ด์๋ง ์ถฉ๋ํ๋๋ก ํํฐ๋ง ํ  ์ ์๋ค. <br>
์์์ ์ ์บ๋ฆญํฐ์ ๋ฐ๋๋ณด๋ค ์ด์ง ์๋ก ์ง์ ํ๋ฉด ๊ฒฝ์ฌ์ง ๋ฉด์ ์ค๋ฅผ๋ ๋ฐ์ด ๋ฌปํ๊ฑฐ๋ ํ  ๊ฒฝ์ฐ์๋ ์ํํ ์ฒดํฌ๊ฐ ๊ฐ๋ฅํ๋ค.
<br><br>
```C#
Camera camera;
camera.ScreenPointToRay(Input.MousePosition)
```
์นด๋ฉ๋ผ๋ก ๋ณด์ด๋ ์ง์ ์ ์ขํ๋ฅผ ํด๋ฆญํ์๋ ๊ทธ ์ขํ ์ง์ ์ ๋ฐ์ด
<br><br>
```C#
Animator.StringToHash("Variables")
```
StringToHash ๋ฅผ ํตํด Animator ์ ์ค์ ํด๋ ํ๋ผ๋ฏธํฐ์ ์ ๊ทผํ  ์ ์๋ค.
<br><br>
  
  </details>

# 2๊ฐ Code
<details mardown="1">
  <summary> 2๊ฐ Code ์ ๋ฆฌ ๋ณด๊ธฐ </summary>

```C#
LateUpdate()
```
๋ชจ๋  Update ํจ์๊ฐ ํธ์ถ ๋ ํ, ๋ง์ง๋ง์ผ๋ก ํธ์ถ <br>
์ฃผ๋ก ์ค๋ธ์ ํธ๋ฅผ ๋ฐ๋ผ๊ฐ๋๋ก ์ค์ ๋ ์นด๋ฉ๋ผ๋ LatedUpdate๋ฅผ ์ฌ์ฉํ๋ค. <br>
์นด๋ฉ๋ผ๊ฐ ๋ชฉํ๋ก ํ๊ณ  ์๋ Object ๊ฐ Update ํจ์ ๋ด์์ ์์ง์ด๊ธฐ ๋๋ฌธ
<br><br>
```C#
Quarternion.AngleAxis(ํ์  ๊ฐ๋, ํ์  ์ถ)
```
์ ๋ํฐ์์๋ ๋ฌผ์ฒด ํ์ ์ ์๊ธฐ๋ ์ง๋ฒ๋ฝ ๋ฌธ์ ๋ฅผ ํด๊ฒฐํ๊ธฐ ์ํด Querternion ์ ์ฌ์ฉํ๋ค.
<br><br>
```C#
Vector3.SmoothDamp(ํ์ฌ ์์น, ๋๋ฌํ๋ ค๋ ์์น, ํ์ฌ ์๋, ๋์ฐฉ์์น๊น์ง ๊ฑธ๋ฆฌ๋ ์๊ฐ, ์ด๋์ ์ต๋์๋, ๊ฒฝ๊ณผ์๊ฐ(?))
```
์นด๋ฉ๋ผ๊ฐ ์์ง์ผ๋ ์์ฐ์ค๋ฝ๊ณ  ๋ถ๋๋ฝ๊ฒ ์์ง์ด๋๋ก ํด์ฃผ๋ ๋ฉ์๋
<br><br>
```C#
OnDrawGizmos()
OnDrawGizmosSelected()
Gizmos.color = Color.Variable
Gizmos.DrawCube(์ค์ฌ๋ถ ์ขํ, ํฌ๊ธฐ)
Gizmos.DrawSphere(์ค์ฌ๋ถ ์ขํ, ๋ฐ์ง๋ฆ) 
```
์ ๋ํฐ Scene ์์ ํน์  ๊ฐ์ฒด์ ์์น๋ฅผ ํํํ  ์ ์๋๋ก ๊ฐ์์ ๊ตฌ์ ํ๋ธ๋ฅผ ๋ง๋๋ ๊ธฐ๋ฅ์ด๋ค.<br>
OnDrawGizmos ๋ ์ฌํ๋ฉด์ ํญ์ ํ์, OnDrawGizmosSelected ๋ ์ค๋ธ์ ํธ๊ฐ ์ ํ๋ฌ์๋๋ง ๋ณด์ด๋๋ก ํ๋ค. <br>
DrawCube ๋ ์ ์ก๋ฉด์ฒด ํํ๋ก ๋ณด์ฌ์ง๊ณ , DrawSphere ๋ ๊ตฌ ํํ๋ก ๋ณด์ฌ์ง๋ค. <br>
๋ชฌ์คํฐ์ ์คํฐ์์น ๊ฐ์ ์ค์ ๋ก ๋ณด์ฌ์ง๋ฉด ์๋๋ ๋ถ๋ถ์ ์์น๋ฅผ ํ์ํ ๋ ์ฉ์ดํจ
<br><br>
```C#
[CustomEditor(typeof(์ด๋ฆ))]
```
ํ์ฅ ์๋ํฐ๋ฅผ ์ฌ์ฉํ๊ธฐ์ํด ํ์ํ ์ ์ธ๋ฌธ
<br><br>
```C#
public override void OnInspectorGUI()
```
์ด ํจ์ ๋ด์ ์ ์๋ ๊ฐ์ฒด์ ์ธ์คํํฐ๋ก ์ปค์คํ GUI๋ฅผ ์ถ๊ฐ ํ  ์ ์๋ค, ๋ฐ๋์ ์ค๋ฒ๋ผ์ด๋ ๋์ด์ผํจ.
<br><br>
```C#
OnSceneGUI()
```
์๋ํฐ๊ฐ Scene ๋ด์ GUI ์์๋ฅผ ์ถ๊ฐํ์ฌ ์ด๋ฒคํธ๋ฅผ ์ฒ๋ฆฌ ํ  ์ ์๋ค.
<br><br>
```C#
Handles.color = new Color(R, G, B, ํฌ๋ช๋)
Handles.DrawSolidDisc(์ค์ฌ์ , ์์ ๊ทธ๋ฆด ์ถ(์๋ง๋?), ๋ฐ์ง๋ฆ)
Handles.DrawWireDisc(์ค์ฌ์ , ์์ ๊ทธ๋ฆด ์ถ(์๋ง๋?), ๋ฐ์ง๋ฆ, ๋๊ป)
Handles.ScaleSlider(์์ ํ  ๊ฐ, ์กฐ์ ์  ์์น, ์กฐ์ ์  ๋ฐฉํฅ, ํ์ , ์กฐ์ ์  ํฌ๊ธฐ, ์์ ํ์ ์ ๊ฐ(?))
Handles.Lable(์์น, ํ์ํ  ํ์คํธ, GUIStyle ์คํ์ผ)
```
color ๋ก ๊ทธ๋ ค์ง ๋ํ์ ์๊ณผ ํฌ๋ช๋๋ฅผ ์ ํ ์ ์๋ค. <br>
DrawSolidDisc ๋ ํ๋๋ฆฌ ์๋ ๊ฝ์ฐฌ ํํ์ ์์ ๊ทธ๋ฆฌ๊ณ  <br>
DrawWireDisc ๋ ํ๋๋ฆฌ๋ง ์๋ ์์ด ๋น ํํ์ ์์ ๊ทธ๋ฆฐ๋ค. <br>
ScaleSlider ๋ ์์ ํ  ๊ฐ์ ์ฌ๋ผ์ด๋๋ฅผ ๋ง๋ ๋ค.<br>
Label ๋ก ํน์  ์์น์ ๊ธ์จ๋ฅผ ๋์ธ์ ์๋ค. ๊ธ์จ์ ์์ฑ์ GUIStyle์์ ์กฐ์ 
<br><br>
```C#
Mathf.Clmap(๋ฒ์๋ฅผ ์ค์ ํ  ๊ฐ, ๋ณํํ ์ ์๋ ์ต์๊ฐ, ๋ณํํ  ์ ์๋ ์ต๋๊ฐ)
```
ํน์  ๊ฐ์ ์ค์ ํ ๋ฒ์ ์ธ์ ๊ฐ์ด ๋์ง ๋ชปํ๋๋ก ํ๋ค.
  <br><br>
```C#
GUIStyle Variables = new GUIStyle()
```
GUI์ ๋ค์ํ ์์ฑ๋ค์ ๊ฐ์ง๊ณ  ์๋ค. ํฐํธ ํฌ๊ธฐ, ์์, ์ ๋ ฌ ๋ฑ๋ฑ...
  <br><br>
  
  </details>
  
# 3๊ฐ ์ ๋ฆฌ
<details mardown="1">
  <summary> 3๊ฐ ์ ๋ฆฌ ๋ณด๊ธฐ </summary>
  
## LightMapping ์ด๋?
Direct Lighting (๋ฐ์ฌ๊ด์ ๊ณ์ฐํ์ง ์์ ๋ผ์ดํ) ๊ณผ InDirect Lighting(๋ฐ์ฌ๊ด์ ๊ณ์ฐํ ๋ผ์ดํ) ๊ณผ ๋น์ ๊ตด์  ๊ฐ์<br>
๋ณตํฉ์ ์ธ ์์๋ค์ ํฉ์ณ ์์์ ํํํ๊ฒ ๋๋ค. <br>
ํ์ง๋ง ์ด๋ฌํ ๊ณ์ฐ์ ์ค์๊ฐ์ผ๋ก ํ๊ธฐ์๋ ๋ถํ๊ฐ ๋ง์ด ๊ฑธ๋ฆฌ๊ธฐ ๋๋ฌธ์, LightMapping ์ด๋ผ๋ ๊ธฐ๋ฒ์ ์ฌ์ฉํ๋ค. <br>
์ ์ ์ธ ์ค๋ธ์ ํธ๋ค์ ๋ํ ์์ ํํ์ ํ์ค์ณ ์ฒ๋ผ ์ํ๋๊ฒ์ด๋ค. ์ ๋ํฐ์์๋ ์ด ๊ณผ์ ์ ๋ฒ ์ดํน์ด๋ผ๊ณ  ๋ถ๋ฅธ๋ค. <br> <br>
  
  ![unknown](https://user-images.githubusercontent.com/80375744/132168168-8f074c26-91f1-4003-9e86-f346640c02bc.png) <br>
ํด๋น ์ฌ์ง์ ๋ผ์ดํธ๋งต์ ๋ฒ ์ดํน ํ ํ, ํฐ๋ ์ธ์ ํฌ๊ธฐ๋ฅผ ์ค์ฌ๋ดค๋๋ ์๊ธด ๊ฒฐ๊ณผ์ธ๋ฐ <br>
ํ์ค์ณ์ฒ๋ผ ์ํ๋ค๋๊ฒ ๋ฌด์จ๋ป์ธ์ง ์ดํด๊ฐ ์๋๋ค๋ฉด ๋์์ด ๋ง์ด ๋ ๊ฒ ๊ฐ๋ค. <br>
์์, ๋ฐ์ฌ๊ด์ ํ์ค์ณ ์ฒ๋ผ ์ํ๋๊ธฐ ๋๋ฌธ์ ํฌ๊ธฐ๋ฅผ ์ค์ธ๋งํผ ๊ทธ๋ฆผ์์ ์ค์  ์ค๋ธ์ ํธ์ ์์น๊ฐ ์ด๊ธ๋์๋ ๋ชจ์ต์ด๋ค. <br>
  
## Global Illumination ์ด๋?
๋น์ด ํ๋ฉด์ ๋ฟ์ผ๋ฉด ๋ฐ์ฌ, ํฌ๊ณผ, ๊ตด์ , ์ฐ๋ ๋ฑ ๋ค์ํ ์ํธ์์ฉ์ด ์๊ธฐ๊ฒ ๋๋ค. <br>
๋น์ด ๋ฟ์ ํ๋ฉด์ ๋ฐ์ฌ๋๋ฉฐ ๊ทธ ์์ฒด๋ก ๋๋ค๋ฅธ ๊ด์์ด ๋๋๋ฐ, ๊ด์์ด ๋ค๋ฅธ๋ฌผ์ฒด์ ์ํฅ์ ์ฃผ๋๊ฑธ ๊ณ์ฐํ๋ ๋ฐฉ์ <br>
https://blog.naver.com/PostView.naver?isHttpsRedirect=true&blogId=canny708&logNo=221552589446 << ์ข๋ ์์ธํ ์์๋ณด๊ธฐ <br>
  
## Light Probe ๋?
๋ฒ ์ดํน๋ ์กฐ๋ช์ ๋ณด๋ฅผ Scene ์ ์ ์ฅํ๋ ๊ธฐ๋ฒ. ์ผํ ๋ค์ผ๋ฉด Lightmapping ๊ณผ ๊ฐ์๊ฒ ์๋๊ฐ ์ถ์ ์ ์๋ค. <br>
Lightmapping ์ ํ๋ฉด์ ๋ํ ์ ๋ณด(ํ์ค์ณ๋ก ์ํ๋๊น)๋ฅผ ์ ์ฅํ์ง๋ง, Light Probe ๋ ๊ณต๊ฐ์ ๋ํ ์ ๋ณด๋ฅผ ์ ์ฅํ๋ค. <br>
์กฐ๊ธ๋ ์ฝ๊ฒ ๋งํ์๋ฉด, ์ค์ ํ ๊ณต๊ฐ์์ ๋ฌผ์ฒด๊ฐ ์์น ํ์๋ ํด๋น ์์น์์ ๋ฐ๋ ๊ด์๊ฐ์ ์ ์ฅํด๋๋ ๊ฒ ๊ฐ์ ๋๋์ด๋ค. <br>
  
## Reflection Probe ๋?
Reflection Mapping ๊ธฐ๋ฒ์ ํตํด ๋ฐ์ฌ๋์ด ๋ณด์ด๋ ์ฃผ๋ณํ๊ฒฝ์ ํ์ค์ณ ํํ๋ก ์ํ๋ ๊ฒ์ด๋ค. <br>
๋๋ฌ์ผ ๋ชจ๋  ๋ฐฉํฅ์ ๊ตฌ๋ฉด ํ์๋ฅผ ์บก์ณํ๋ ์นด๋ฉ๋ผ๊ฐ์ ๊ฒ <br>

  </details>
    
# ํ์ต์ค ๋ฐ์ํ ๋ฒ๊ทธ
<details mardown="1">
  <summary> Character Controller ์ค์ต ์ค ์ ํ ๋ฒ๊ทธ </summary>

 ![GIF](https://user-images.githubusercontent.com/80375744/131792202-925c0b4f-fc08-475f-b45d-67914f36b2d6.gif)
<br>
Chracter Controller ๋ฅผ ํตํด ์บ๋ฆญํฐ๋ฅผ ์กฐ์ข ํ๋์ค ๋ฐ์ํ ๋ฌธ์ ์ด๋ค. <br>
์บ๋ฆญํฐ์ ์ ํ๊ฐ ์ํํ์ง ์์ ์บ๋ฆญํฐ๊ฐ ๋์ ์๋์ง ์ฒดํฌํ๋ ๋ณ์ isGrounded ์ ๊ฐ์ ์ฒดํฌํด ๋ณด์๋๋ฐ <br>
๋ถ๋ชํ ๋์ ๋ฐ๊ณ  ์์์๋ false ๋ฅผ ์ถ๋ ฅํ๋ค๊ฐ ์์ฃผ ๊ฐ๋ True ๊ฐ ๋๋ฉด์ ์ ํ๊ฐ ๋ฒ๋ฒ์ด๋ ๋ฌธ์ ์ ์ด๋ค. <br>

## ์ฌ์ฉ ์ฝ๋
  <details mardown="1">
  <summary> ์ฌ์ฉํ ์ฝ๋ ๋ณด๊ธฐ </summary>
  
```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerChracter_Bug : MonoBehaviour
{
    #region Variables
    public float speed = 5f;            // ์ด๋์๋
    public float jumpHeight = 4f;       // ์ ํ ๋์ด
    public float dashDistance = 5f;     // ๋์ฌ ๊ฑฐ๋ฆฌ
    public float gravity = -9.81f;      // ์ค๋ ฅ

    private bool isGrounded;     // ์บ๋ฆญํฐ๊ฐ ๋์ ์์๋์ง ์๋์ง ์ฒดํฌ ์ฌ๋ถ

    public Vector3 drags;               // ๊ณต๊ธฐ์ ํญ
    public LayerMask groundLayerMask;   // ์บ๋ฆญํฐ์ ์ถฉ๋ํ  ๋ ์ด์ด ์ค์ 

    private CharacterController characterController;    // ์ ์ด๊ถํ ํ๋์ ์ํ ๋ณ์ ์ ์ธ
    private Vector3 calcVelocity;       // ์บ๋ฆญํฐ์ ๋ฒกํฐ ๊ณ์ฐ ๊ฐ์ ๋ด์๋ ์์ ๋ณ์

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
        isGrounded = characterController.isGrounded; // CharacterController ์ ์๋ isGrounded ๋ณ์ ์ฌ์ฉ

        if (isGrounded && calcVelocity.y < 0)   // ๋์์ ์์์๋
        {
            calcVelocity.y = 0;     // y์ถ ๋ฐฉํฅ์ ์ ํญ๋ ฅ์ ์์ฐ
        }

        // ์บ๋ฆญํฐ ์ด๋
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));  // ์บ๋ฆญํฐ์ ์ด๋ ๋ฐฉํฅ ๋ฐ์์ค๊ธฐ
        characterController.Move(move * Time.deltaTime * speed);    // ๊ฒ์ ์คํ์ ๋ณด์ด๋ ์บ๋ฆญํฐ ์ด๋์ํค๊ธฐ

        if (move != Vector3.zero)   // ์บ๋ฆญํฐ๊ฐ ์ด๋์ค์ด๋ฉด
        {
            transform.forward = move;   // ํด๋น ๋ฐฉํฅ์ ๋ณด๋๋ก ํจ
        }

        // ์ ํ
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)  // ๋์ ์์๋ ์ ํ๋ฅผ ๋๋ฅด๋ฉด
        {
            calcVelocity.y += Mathf.Sqrt(jumpHeight * -2f * Physics.gravity.y); // ์ ํ
        }

        // ๋์ฌ
        if (Input.GetKeyDown(KeyCode.LeftShift))    // ๋์ฌ ๋ฒํผ์ ๋๋ฅด๋ฉด
        { 
            Vector3 dashVelocity = Vector3.Scale(transform.forward,
                                    dashDistance * new Vector3((Mathf.Log(1f / (Time.deltaTime * drags.x + 1)) / -Time.deltaTime),
                                    0,
                                    (Mathf.Log(1f / (Time.deltaTime * drags.z + 1)) / -Time.deltaTime)));   // ๋์ฌ
            calcVelocity += dashVelocity;   // ์บ๋ฆญํฐ์ ์ ์ฉ๋  ๋ฒกํฐ ๊ฐ ์ถ๊ฐ
        }

        // ์ค๋ ฅ ๊ณ์ฐ
        calcVelocity.y += gravity * Time.deltaTime;

        // ๊ณต๊ธฐ์ ํญ ๊ณ์ฐ
        calcVelocity.x /= 1 + drags.x * Time.deltaTime;
        calcVelocity.y /= 1 + drags.y * Time.deltaTime;
        calcVelocity.z /= 1 + drags.z * Time.deltaTime;

        characterController.Move(calcVelocity * Time.deltaTime);    // ์ค๋ ฅ๊ณผ ๊ณต๊ธฐ์ ํญ์ ์ด๋์์ ๋ํจ
    }
}
```
<br>
    </details>
<br>
    
<details mardown="1">
<summary> ๋ฌธ์  ํด๊ฒฐ์ ์ํด ์ฐพ์๋ณธ ์ ๋ณด </summary>
      
![GIF2](https://user-images.githubusercontent.com/80375744/131794661-63cec765-858c-416b-9c1c-2ea8ce8b8603.gif)
๋ฌธ์  ํด๊ฒฐ์ ์ํด calcVelocity.y ์ ๊ฐ์ด ์๋ชป๋์ด ๊ทธ๋ฐ๊ฒ ์๋๊น ์ถ์ด Debug ๋ฅผ ํ์ฉํด ์์น๋ฅผ ํ์ธํด๋ณด์๋๋ <br>
isGrounded ๋ผ๋ ๋ณ์๋ calcVelocity.y ์ ๊ฐ์ด ์ ํํ 0 ์ผ๋๋ง True ๋ฅผ ๋ฐํํ์ง๋ง <br>
ํ์ฌ ์บ๋ฆญํฐ์ y์ขํ๊ฐ์ด ๋ฏธ์ธํ๊ฒ 0 ์ดํ๋ก ๋จ์ด์ ธ์์ด์ ์๊พธ๋ง false ๋ฅผ ๋ฐํํ๋ ๊ฒ ๊ฐ๋ค.
<br><br>
https://tech.lonpeach.com/2019/09/15/UniRx-Example-IsGrounded/ <br>
๊ตฌ๊ธ์ ๊ฒ์ํด๋ณด๋, isGrounded ์์ฒด์ ์ ์ง ํ์  ์ ๋ฐ๋๊ฐ ๊ต์ฅํ ๋ณ๋ก๋ผ๊ณ  ํ๋ค. <br>
๊ทธ๋์ Raycast ์ ๋ณํํ์ฌ ํ์ ํ๋ค๊ณ  ํ๋๋ฐ, ๋๋ฆ๋๋ก ๋ธ๋ ฅํด๋ณด์์ง๋ง <br>
์ง๊ธ ๋ด ์ง์ ์์ค์ผ๋ก Raycast ๋ฅผ ํ์ฉํ๊ธฐ๋ ํ๋ค์ด์ ๊ณ ์น์ง ๋ชปํ๋ค.
<br><br>
ํ์ฌ ์ ์ํ๊ณ ์ ํ๋ ๊ฒ์์ ๋ชฉํ๋ ํ๋ค์ด ๋ทฐ ํ์์ RPG ๊ฒ์์ ์์ด ๋ชฉํ์ด๋ฏ๋ก <br>
ํ๋ค์ด ๋ทฐ ํ์์ RPG ๊ฒ์๋ค์์๋ ์ ํ๊ฐ ์๋ ๊ฒฝ์ฐ๋ ์๊ธฐ ๋๋ฌธ์, ํ์ฌ ์ค์ํ๊ฒ ๋ค๋ค์ผํ  ๋ฌธ์ ๋ ์๋๋ผ ์๊ฐํ์ฌ ์ผ๋จ ๋๊ธฐ๊ธฐ๋ก ํ๋ค.
        
</details>
        
</details>
