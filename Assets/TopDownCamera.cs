using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCamera : MonoBehaviour
{
    #region Variables
    public float height = 5f;           // 카메라 높이
    public float distance = 10;         // 대상으로부터 카메라가 떨어진 거리
    public float angle = 45f;           // 카메라의 각도
    public float lookAtHeight = 2f;     // 목표 타겟의 높이
    public float smoothSpeed = 0.5f;    // 카메라의 이동시 부드러운 정도

    private Vector3 refVelocity;        // 내부 계산을 위한 임시 변수

    public Transform target;    // Transform 은 위치, 회전, 크기를 담고있는 컴포넌트이다.
    #endregion Variables

    // 카메라 이동시 더 자연스럽게 움직이기 위해 LateUpdate 사용
    private void LateUpdate()
    {
        HandleCamera();
    }

    public void HandleCamera() 
    {
        if (!target)    // target 이 존재하지 않으면
        {
            return;     // 함수 종료
        }

        // 카메라의 wordlPosition 계산 (카메라가 보고있는 위치)
        Vector3 worldPosition = (Vector3.forward * -distance) + (Vector3.up * height);  // -distance 값을 곱하는 이유는 target의 뒤쪽에서 볼 것 이기 때문
        // Debug.DrawLine(target.position, worldPosition, Color.red);

        // 카메라의 회전값 계산
        Vector3 rotatedVector = Quaternion.AngleAxis(angle, Vector3.up) * worldPosition;    // 물체를 돌릴때 생기는 짐볼락 현상을 해결하기 위해 Unity 에서는 Quaternion을 사용한다.
        // Debug.DrawLine(target.position, rotatedVector, Color.green);

        // 카메라 위치 재설정
        Vector3 finalTargetPosition = target.position;          // 카메라의 최종 위치 결정
        finalTargetPosition.y += lookAtHeight;                  // 카메라의 위치에서 lookAtHeight 수치 만큼 위에서 내려다보는 형태로 만든다

        Vector3 finalPoistion = finalTargetPosition + rotatedVector;    // 카메라의 최종 시야는 finalPosition + rotatedVector (카메라 위치 + 카메라 방향각)
        // Debug.DrawLine(target.position, finalPoistion, Color.blue);

        transform.position = Vector3.SmoothDamp(transform.position, finalPoistion, ref refVelocity, smoothSpeed);   // 카메라의 위치를 부드럽게 바꾸기 위해 SmoothDamp 라는 함수 사용

        transform.LookAt(target.position);              // target.positon 의 좌표에서 카메라가 보도록 한다.
    }

    private void OnDrawGizmos()     // 카메라의 위치와 카메라가 보고있는 중심을 가상의 구 형태로 보여주는 함수
    {
        Gizmos.color = new Color(1f, 0f, 0f, 0.5f);
        if (target)
        {
            Vector3 lookAtPosition = target.position;
            lookAtPosition.y += lookAtHeight;
            Gizmos.DrawLine(transform.position, lookAtPosition);
            Gizmos.DrawSphere(lookAtPosition, 0.25f);       // 카메라가 보고있는 중심
        }

        Gizmos.DrawSphere(transform.position, 0.25f);       // 카메라의 위치
    }
}
