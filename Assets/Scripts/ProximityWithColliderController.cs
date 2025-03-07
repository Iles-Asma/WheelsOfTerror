using UnityEngine;

[RequireComponent (typeof(Collider))]
public class ProximityWithColliderController : MonoBehaviour
{
    private const string PLAYER_TAG = "Player";

    [SerializeField] CollectibleAnimationController m_AnimatedCollectible;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != PLAYER_TAG)
        {
            return;
        }

        Debug.Log($"Player entering {name}'s trigger");

        m_AnimatedCollectible.SetPlayerWithinRange(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag != PLAYER_TAG)
        {
            return;
        }

        Debug.Log($"Player leaving {name}'s trigger");

        m_AnimatedCollectible.SetPlayerWithinRange(false);

    }
}
