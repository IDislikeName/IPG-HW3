using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Enemy
{
    public class EnemyBehavior : MonoBehaviour
    {
        NavMeshAgent ag;
        public Transform player;
        Animator anim;
        public bool dead = false;
        bool pathing = false;
        // Start is called before the first frame update
        void Start()
        {
            ag = GetComponent<NavMeshAgent>();
            anim = GetComponent<Animator>();
            StartCoroutine(StartPathing());
            player = GameObject.Find("Player").transform;
        }

        // Update is called once per frame
        void Update()
        {
            if(!dead&&pathing)
                ag.SetDestination(player.position);
        }
        IEnumerator StartPathing()
        {
            yield return new WaitForSeconds(1f);
            pathing = true;
        }
        public void Die()
        {
            dead = true;
            ag.isStopped = true;
            anim.SetTrigger("Die");
            GameManager.instance.score++;
        }
        public void D()
        {
            Destroy(gameObject);
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("Player") && !dead &&pathing)
            {
                GameManager.instance.Lose();
            }
        }
        private void OnCollisionStay(Collision collision)
        {
            if (collision.collider.CompareTag("Player") && !dead && pathing)
            {
                GameManager.instance.Lose();
            }
        }
    }
}

