using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterAnimationController : MonoBehaviour
{
   private Animator animator;

   private void Start()
   {
      animator = GetComponent<Animator>();
   }

   void Update()
   {
      HandleAnimations();
   }

   private void HandleAnimations()
   {
      if(Input.GetAxis("Horizontal") !=0)
      {
         animator.SetTrigger("RunTrigger");
      }
      else
      {
         animator.SetTrigger("IdleTrigger");
      }
      
      if (Input.GetButtonDown("Jump"))
      {
         animator.SetTrigger("JumpTrigger");
      }
      
      if (Input.GetKeyDown(KeyCode.W))
      {
         animator.SetTrigger("WallJumpTrigger");
      }
   }
}
