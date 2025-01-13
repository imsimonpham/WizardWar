using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class AnimateHandsController : MonoBehaviour
{
    [SerializeField] InputActionReference _gripInputActionRef;
    [SerializeField] InputActionReference _triggerInputActionRef;

    private Animator _anim;
    private float _gripValue;
    private float _triggerValue;

    private void Start()
    {
        _anim = GetComponent<Animator>();
    }

    private void Update()
    {
        AnimateGrip();
        AnimateTrigger();
    }

    void AnimateGrip()
    {
        _gripValue = _gripInputActionRef.action.ReadValue<float>();
        _anim.SetFloat("Grip", _gripValue);
    }

    void AnimateTrigger()
    {
        _triggerValue = _triggerInputActionRef.action.ReadValue<float>();
        _anim.SetFloat("Trigger", _triggerValue);
    }
}
