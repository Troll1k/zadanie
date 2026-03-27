using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    [Header("Ustawienia celu")]
    public Transform player;

    [Header("Ustawienia AI")]
    public float updateRate = 0.2f;

    private NavMeshAgent agent;

    private void Awake()
    {
       agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(UpdatePath), 0f, updateRate);
    }

    void UpdatePath()
    {
        if (player != null && agent.enabled && agent.isOnNavMesh)
        {
            agent.SetDestination(player.position);
        }
    }
}
