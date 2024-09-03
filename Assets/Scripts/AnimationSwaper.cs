using UnityEngine;

public class AnimationSwaper : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Swap()
    {
        animator.SetBool("IsOpen", !animator.GetBool("IsOpen"));   
    }
}
