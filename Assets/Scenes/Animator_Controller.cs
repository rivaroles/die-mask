using UnityEngine;
using UnityEngine.UI;


public class Animator_Controller : MonoBehaviour
{
    private animator Copo;


    public void AnimationState1(){
     Copo.SetInteger("State", stateIndex);
  }
  
}
