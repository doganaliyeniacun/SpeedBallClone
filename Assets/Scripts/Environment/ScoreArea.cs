using UnityEngine;
using UnityEngine.Events;

public class ScoreArea : MonoBehaviour
{
    public UnityEvent scoreEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(GameplayManager.playerName))
        {
            scoreEvent?.Invoke();
        }
    }
}
