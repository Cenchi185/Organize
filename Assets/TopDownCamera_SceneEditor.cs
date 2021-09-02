using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// TopDownCamera �� �����Ҽ� �ִ� ����� ���� ��ũ��Ʈ�� ����
[CustomEditor(typeof(TopDownCamera))]   // �����ڸ� �������־�� CustomEditor �� Ȱ��ȭ ��
public class TopDownCamera_SceneEditor : Editor 
{
    #region Variables
    private TopDownCamera targetCamera; // TopDownCamera �� ����ϱ� ���� targetCamera ��� ������ �޾ƿ�
    #endregion Variables

    // MonoBehavior Ŭ������ �ƴϱ⶧���� �ڵ����� ������ Update �� Start �Լ��� �� �ʿ䰡 ����.
        public override void OnInspectorGUI()
    {
        targetCamera = (TopDownCamera)target;   // targetCamera �� TopDownCamera �� target �Ӽ��� ������ ����
        base.OnInspectorGUI();                  // �� �Լ��� ȣ���ϴ°�����, ������ GUI ��Ҹ� ȭ�鿡 �߰��Ͽ� ���� �� �� �ִ�.
    }

    private void OnSceneGUI()       // �޾ƿ� ī�޶��� Editor ����� Ȯ���ϱ� ���� �ش� �Լ��� ���
    {
        if (!targetCamera || !targetCamera.target)  // targetCamera �� �����ϴ���, targetCamera �� target �� �����ϴ����� �Ǵ�
        {
            return;     // ������ �Լ��� ������
        }

        Transform cameraTarget = targetCamera.target;       // ī�޶��� target�� ������
        Vector3 targetPosition = cameraTarget.position;     // ī�޶��� target ��ġ�� �޾ƿ�
        targetPosition.y += targetCamera.lookAtHeight;      // y���� ī�޶��� lookAtHeight�� ���

        // ī�޶� Distance�� ǥ���ϴ� ���� �߰�
        Handles.color = new Color(1f, 0f, 0f, 0.15f);                               // ī�޶��� �þ� ������ ǥ���ϴ� ���� ����
        Handles.DrawSolidDisc(targetPosition, Vector3.up, targetCamera.distance);   // ī�޶��� �þ� ������ ���� ������ ǥ��

        Handles.color = new Color(0f, 1f, 0f, 0.75f);                               // ī�޶��� �þ� ������ ǥ���ϴ� ���� ����
        Handles.DrawWireDisc(targetPosition, Vector3.up, targetCamera.distance);    // ī�޶��� �þ� �׵θ��� ��� �׵θ������� ǥ��

        // ī�޶��� �þ� ���� ���� �����̴�
        Handles.color = new Color(1f, 0f, 0f, 0.15f);                                   // �þ߹��� �����ϴ� �����̴��� ����
        targetCamera.distance = Handles.ScaleSlider(targetCamera.distance, targetPosition, -cameraTarget.forward, Quaternion.identity, targetCamera.distance, 0.1f);
        // distance �� �����ϴ� ScaleSlider �߰� (������ ��, �����̴��� ��ġ, �����̴��� ����, �����̴� ȸ��, �����̴��� ũ��, �����Ǵ� ����)
        targetCamera.distance = Mathf.Clamp(targetCamera.distance, 2f, float.MaxValue); // �����̴��� ���� ������ �ּ�, �ִ� ����

        // ī�޶��� ������ ���� �����̴�
        Handles.color = new Color(0f, 0f, 1f, 0.5f);                                    // �þ� ������ ���� �����̴��� ��
        targetCamera.height = Handles.ScaleSlider(targetCamera.height, targetPosition, Vector3.up, Quaternion.identity, targetCamera.height, 0.1f);
        // height �� �����ϴ� ScalseSlider �߰�
        targetCamera.height = Mathf.Clamp(targetCamera.height, 2f, float.MaxValue);     // �����̴��� ���� ������ �ּ�, �ִ� ����

        // ���� �ĺ��� ���� ���� �Ӽ�
        GUIStyle labelStyle = new GUIStyle();               
        labelStyle.fontSize = 15;                       // ��Ʈ ũ��
        labelStyle.normal.textColor = Color.white;      // ��Ʈ ��
        labelStyle.alignment = TextAnchor.UpperCenter;  // �ؽ�Ʈ ���� ����

        Handles.Label(targetPosition + (-cameraTarget.forward * targetCamera.distance), "Distance", labelStyle); // ���� ���κп� Distance ��� �� �߰�

        labelStyle.alignment = TextAnchor.MiddleRight;
        Handles.Label(targetPosition + (Vector3.up * targetCamera.height), "Height", labelStyle);                // ���� ���κп� Height ��� �� �߰�

        targetCamera.HandleCamera();
    }
}
