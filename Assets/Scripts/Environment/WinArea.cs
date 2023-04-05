using UnityEngine;
using UnityEngine.Events;

public class WinArea : MonoBehaviour
{
    public UnityEvent winAreaEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(GameplayManager.playerName))
        {
            winAreaEvent?.Invoke();
        }
    }
}
