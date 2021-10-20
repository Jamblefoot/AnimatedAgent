using UnityEngine;
using UnityEngine.AI;

public class AnimatedAgent : MonoBehaviour
{
    Animator anim;
    NavMeshAgent agent;

    Vector3 localVelocity = Vector3.zero;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.updatePosition = false;
    }

    void Update()
    {
        if((agent.destination - transform.position).magnitude > agent.stoppingDistance)
            anim.SetBool("move", true);
        else anim.SetBool("move", false);
        localVelocity = transform.InverseTransformDirection(agent.velocity);
        anim.SetFloat("speed", localVelocity.z);

    }

    void OnAnimatorMove()
    {
        Vector3 position = anim.rootPosition;
        position.y = agent.nextPosition.y;
        transform.position = position;
        transform.Rotate(0f, agent.angularSpeed * Time.deltaTime * localVelocity.x, 0f, Space.Self);
        agent.nextPosition = transform.position;
    }
}
