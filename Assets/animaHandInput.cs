using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class animaHandInput : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public Animator handAnimator;
    public InputActionProperty gripAnimationAction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float trig_val = pinchAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", trig_val);
        float grip_val = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", grip_val);
    }
}
