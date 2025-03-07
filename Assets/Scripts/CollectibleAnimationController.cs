using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CollectibleAnimationController : MonoBehaviour
{
    private const string PLAYER_WITHIN_RANGE_ANIM_KEY = "IsPlayerWithinRange";

    [SerializeField] Animator m_Animator;

    public void SetPlayerWithinRange(bool value)
    {
        m_Animator.SetBool(PLAYER_WITHIN_RANGE_ANIM_KEY, value);
    }
}
