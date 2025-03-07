using UnityEngine;
using UnityEngine.Assertions;

public class ProximityController : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";

    [SerializeField] float m_Distance = 2f;

    [SerializeField] CollectibleAnimationController m_AnimatedCollectible;

    Transform m_Target;
    float m_SqrDistance;
    bool m_IsTargetWithinDistance;

    void Awake()
    {
        GameObject player = GameObject.FindGameObjectWithTag(PLAYER_TAG);

        Assert.IsNotNull(player, $"Can't find any valid player with tag {PLAYER_TAG}");

        m_Target = player.transform;
        m_SqrDistance =  m_Distance * m_Distance;
    }

    void Update()
    {
        Vector3 distance = m_Target.position - transform.position;

        UpdateProximity(distance.sqrMagnitude < m_SqrDistance);
    }

    void UpdateProximity(bool isWithinProximity)
    {
        if (m_IsTargetWithinDistance == isWithinProximity)
        {
            return;
        }

        m_IsTargetWithinDistance = isWithinProximity;

        m_AnimatedCollectible.SetPlayerWithinRange(isWithinProximity);
    }
}
