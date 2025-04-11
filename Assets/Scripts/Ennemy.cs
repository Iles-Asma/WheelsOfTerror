using UnityEngine;
using UnityEngine.AI;

 public class EnemyAI : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player; // Reference du joueur
    public float detectRange = 30f; // distance a laquelle l'ennemie suie le joueur
    public float stopDistance = 2f; // distance a laquelle l'ennemie s'arrête
    public float updateRate = 0.5f; // fréquence de mise à jour de la détection

    private float nextUpdateTime = 0f; // gestion de mis a jour du temps

    void Start() { 
        agent = GetComponent<NavMeshAgent>();
        if (agent == null)
        {
            Debug.LogError("NavMeshAgent is missing on " + gameObject.name);
        }

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

        // arret de l'ennemi quand il est trop proche du joueur
        if (distanceToPlayer <= stopDistance) {

            agent.isStopped = true;
        
        }else
        {
            agent.isStopped = false;
        }
         if (agent == null) return;

    }

}

