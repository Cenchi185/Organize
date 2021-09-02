using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleRandomStateMachineBehaviour : StateMachineBehaviour
{
    #region Variables
    public int numberOfstates = 2;  // 변화될 애니메이션 갯수 (기본 애니메이션 제외)
    public float minNormTime = 0f;  // 기본 애니메이션의 최소 실행 시간
    public float maxNormTime = 5f;  // 기본 애니메이션의 최대 실행 시간

    public float randomNormalTime;  // 계산용

    readonly int hashRandomIdle = Animator.StringToHash("RandomIdle");  // 파라미터로 설정해둔 RandomIdle에 접근 권한

    #endregion Variables
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)   // 기본 상태에 진입 했을때 실행되는 함수
    {
        // 상태 변화에 필요한 시간을 결정
        randomNormalTime = Random.Range(minNormTime, maxNormTime);
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)  // 기본 상태 진입 후 상태 변화시에 호출되는 함수
    {
        // 만약 현재 상태가 baselayer 에 있는 상태라면 
        if (animator.IsInTransition(0) && animator.GetCurrentAnimatorStateInfo(0).fullPathHash == stateInfo.fullPathHash) 
        {
            animator.SetInteger(hashRandomIdle, -1);                                    // 랜덤 변수를 -1 로 고정하여 다른 애니메이션이 재생되지 못하도록 막음
        }

        // 만약 현재 상태가 상태변화에 필요한 시간을 지났다면 (randomNormalTime 보다 크고, baselayer 에 있는 상태가 아니라면)
        if (stateInfo.normalizedTime > randomNormalTime && !animator.IsInTransition(0))
        {
            animator.SetInteger(hashRandomIdle, Random.Range(0, numberOfstates + 1));   // 랜덤 변수를 통해 1번 또는 2번 애니메이션을 재생
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
