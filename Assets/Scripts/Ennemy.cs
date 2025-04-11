using UnityEngine;
using UnityEngine.AI

 public class EnemyAI : Monobehavior
{
    public NavMeshAgent agent;
    public TransForm player; // Reference du joueur
    public float detectRange = 30f; // distance a laquelle l'ennemie suie le joueur
    public float stopDistance = 2f; // distance a laquelle l'ennemie s'arr�te
    public float updateRate = 0.5f; // fr�quence de mise � jour de la d�tection

    public NavMeshAgent agent;
    private float nextUpdateTime = 0f; // gestion de mis a jour du temps

    void Start() { 
        agent = GetComponent<NavMeshAgent>();

    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(player.position, transform.position);

        if (distanceToPlayer < detectRange)
        {
            // delai avant de recalculer la destination
            nextUpdateTime -= Time.deltaTime;
            if (nextUpdateTime <= 0f)
            {
                // mis a jour de la destination de l'ennemi et reinitialisation du timer
                agent.SetDestination(player.position);
                nextUpdateTime = updateRate;
            }

        }
    }




}

