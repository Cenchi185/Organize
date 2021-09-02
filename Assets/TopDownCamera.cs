using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCamera : MonoBehaviour
{
    #region Variables
    public float height = 5f;           // ī�޶� ����
    public float distance = 10;         // ������κ��� ī�޶� ������ �Ÿ�
    public float angle = 45f;           // ī�޶��� ����
    public float lookAtHeight = 2f;     // ��ǥ Ÿ���� ����
    public float smoothSpeed = 0.5f;    // ī�޶��� �̵��� �ε巯�� ����

    private Vector3 refVelocity;        // ���� ����� ���� �ӽ� ����

    public Transform target;    // Transform �� ��ġ, ȸ��, ũ�⸦ ����ִ� ������Ʈ�̴�.
    #endregion Variables

    // ī�޶� �̵��� �� �ڿ������� �����̱� ���� LateUpdate ���
    private void LateUpdate()
    {
        HandleCamera();
    }

    public void HandleCamera() 
    {
        if (!target)    // target �� �������� ������
        {
            return;     // �Լ� ����
        }

        // ī�޶��� wordlPosition ��� (ī�޶� �����ִ� ��ġ)
        Vector3 worldPosition = (Vector3.forward * -distance) + (Vector3.up * height);  // -distance ���� ���ϴ� ������ target�� ���ʿ��� �� �� �̱� ����
        // Debug.DrawLine(target.position, worldPosition, Color.red);

        // ī�޶��� ȸ���� ���
        Vector3 rotatedVector = Quaternion.AngleAxis(angle, Vector3.up) * worldPosition;    // ��ü�� ������ ����� ������ ������ �ذ��ϱ� ���� Unity ������ Quaternion�� ����Ѵ�.
        // Debug.DrawLine(target.position, rotatedVector, Color.green);

        // ī�޶� ��ġ �缳��
        Vector3 finalTargetPosition = target.position;          // ī�޶��� ���� ��ġ ����
        finalTargetPosition.y += lookAtHeight;                  // ī�޶��� ��ġ���� lookAtHeight ��ġ ��ŭ ������ �����ٺ��� ���·� �����

        Vector3 finalPoistion = finalTargetPosition + rotatedVector;    // ī�޶��� ���� �þߴ� finalPosition + rotatedVector (ī�޶� ��ġ + ī�޶� ���Ⱒ)
        // Debug.DrawLine(target.position, finalPoistion, Color.blue);

        transform.position = Vector3.SmoothDamp(transform.position, finalPoistion, ref refVelocity, smoothSpeed);   // ī�޶��� ��ġ�� �ε巴�� �ٲٱ� ���� SmoothDamp ��� �Լ� ���

        transform.LookAt(target.position);              // target.positon �� ��ǥ���� ī�޶� ������ �Ѵ�.
    }

    private void OnDrawGizmos()     // ī�޶��� ��ġ�� ī�޶� �����ִ� �߽��� ������ �� ���·� �����ִ� �Լ�
    {
        Gizmos.color = new Color(1f, 0f, 0f, 0.5f);
        if (target)
        {
            Vector3 lookAtPosition = target.position;
            lookAtPosition.y += lookAtHeight;
            Gizmos.DrawLine(transform.position, lookAtPosition);
            Gizmos.DrawSphere(lookAtPosition, 0.25f);       // ī�޶� �����ִ� �߽�
        }

        Gizmos.DrawSphere(transform.position, 0.25f);       // ī�޶��� ��ġ
    }
}
