using StarterAssets;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(StarterAssetsInputs))]
public class AutomateController : MonoBehaviour
{
    private static readonly float WALK_DURATION = 5f;

    private float m_horizontalDirection = 1;

    private StarterAssetsInputs m_inputs;

    private void Awake()
    {
        m_inputs = GetComponent<StarterAssetsInputs>();
    }

    void Start()
    {
        StartCoroutine("Walk");
    }

    IEnumerator Walk()
    {
        while(true)
        {
            m_horizontalDirection = -m_horizontalDirection;

            m_inputs.MoveInput(new Vector2(m_horizontalDirection, 0f));

            yield return new WaitForSeconds(WALK_DURATION);
        }
    }
}
