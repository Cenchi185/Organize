using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// TopDownCamera 를 편집할수 있는 기능을 가진 스크립트를 만듦
[CustomEditor(typeof(TopDownCamera))]   // 지정자를 설정해주어야 CustomEditor 가 활성화 됨
public class TopDownCamera_SceneEditor : Editor 
{
    #region Variables
    private TopDownCamera targetCamera; // TopDownCamera 를 사용하기 위해 targetCamera 라는 변수로 받아옴
    #endregion Variables

    // MonoBehavior 클래스가 아니기때문에 자동으로 생성된 Update 와 Start 함수는 쓸 필요가 없다.
        public override void OnInspectorGUI()
    {
        targetCamera = (TopDownCamera)target;   // targetCamera 는 TopDownCamera 의 target 속성을 가지고 있음
        base.OnInspectorGUI();                  // 이 함수를 호출하는것으로, 기존의 GUI 요소를 화면에 추가하여 같이 볼 수 있다.
    }

    private void OnSceneGUI()       // 받아온 카메라의 Editor 기능을 확장하기 위해 해당 함수를 사용
    {
        if (!targetCamera || !targetCamera.target)  // targetCamera 가 존재하는지, targetCamera 의 target 이 존재하는지를 판단
        {
            return;     // 없으면 함수를 종료함
        }

        Transform cameraTarget = targetCamera.target;       // 카메라의 target을 가져옴
        Vector3 targetPosition = cameraTarget.position;     // 카메라의 target 위치를 받아옴
        targetPosition.y += targetCamera.lookAtHeight;      // y값은 카메라의 lookAtHeight를 사용

        // 카메라 Distance를 표시하는 위젯 추가
        Handles.color = new Color(1f, 0f, 0f, 0.15f);                               // 카메라의 시야 범위를 표시하는 위젯 색깔
        Handles.DrawSolidDisc(targetPosition, Vector3.up, targetCamera.distance);   // 카메라의 시야 범위를 빨간 원으로 표시

        Handles.color = new Color(0f, 1f, 0f, 0.75f);                               // 카메라의 시야 범위를 표시하는 위젯 색깔
        Handles.DrawWireDisc(targetPosition, Vector3.up, targetCamera.distance);    // 카메라의 시야 테두리를 녹색 테두리원으로 표시

        // 카메라의 시야 범위 수정 슬라이더
        Handles.color = new Color(1f, 0f, 0f, 0.15f);                                   // 시야범위 조절하는 슬라이더의 색깔
        targetCamera.distance = Handles.ScaleSlider(targetCamera.distance, targetPosition, -cameraTarget.forward, Quaternion.identity, targetCamera.distance, 0.1f);
        // distance 를 조정하는 ScaleSlider 추가 (수정될 값, 슬라이더의 위치, 슬라이더의 방향, 슬라이더 회전, 슬라이더의 크기, 조정되는 단위)
        targetCamera.distance = Mathf.Clamp(targetCamera.distance, 2f, float.MaxValue); // 슬라이더의 조정 가능한 최소, 최대 범위

        // 카메라의 높낮이 수정 슬라이더
        Handles.color = new Color(0f, 0f, 1f, 0.5f);                                    // 시야 높낮이 조정 슬라이더의 색
        targetCamera.height = Handles.ScaleSlider(targetCamera.height, targetPosition, Vector3.up, Quaternion.identity, targetCamera.height, 0.1f);
        // height 를 조절하는 ScalseSlider 추가
        targetCamera.height = Mathf.Clamp(targetCamera.height, 2f, float.MaxValue);     // 슬라이더의 조정 가능한 최소, 최대 범위

        // 위젯 식별을 위한 라벨의 속성
        GUIStyle labelStyle = new GUIStyle();               
        labelStyle.fontSize = 15;                       // 폰트 크기
        labelStyle.normal.textColor = Color.white;      // 폰트 색
        labelStyle.alignment = TextAnchor.UpperCenter;  // 텍스트 정렬 방향

        Handles.Label(targetPosition + (-cameraTarget.forward * targetCamera.distance), "Distance", labelStyle); // 위젯 끝부분에 Distance 라는 라벨 추가

        labelStyle.alignment = TextAnchor.MiddleRight;
        Handles.Label(targetPosition + (Vector3.up * targetCamera.height), "Height", labelStyle);                // 위젯 끝부분에 Height 라는 라벨 추가

        targetCamera.HandleCamera();
    }
}
