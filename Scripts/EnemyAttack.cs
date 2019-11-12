using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] float damage = 40f;
    [SerializeField] Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
        animator = GetComponent<Animator>();
    }

    public void AttackHitEvent()
    {
        if (target.hitPoints <= 0)
        {
            FindObjectOfType<EnemyAI>().enabled = false;
            animator.SetBool("attack", false);
            animator.SetTrigger("idle");
            return;
        }
        if (target == null) return;
        target.TakeDamagePlayer(damage);
        target.GetComponent<DisplayDamage>().ShowDamageImpact();
        //Debug.Log("bang bang");
    }
}
