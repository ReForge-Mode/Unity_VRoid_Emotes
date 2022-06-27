using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpressionControl : MonoBehaviour
{
    [SerializeField] private Animator anim;

    public void SetPose_Idle()
    {
        anim.SetTrigger("Idle");
    }

    public void SetPose_Surprised()
    {
        anim.SetTrigger("Surprised");
    }

    public void SetPose_Love()
    {
        anim.SetTrigger("Love");
    }

    public void SetPose_Angry()
    {
        anim.SetTrigger("Angry");
    }

    public void SetPose_Magic()
    {
        anim.SetTrigger("Magic");
    }

    public void SetPose_Thinking()
    {
        anim.SetTrigger("Thinking");
    }
}
