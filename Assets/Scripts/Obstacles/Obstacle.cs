using UnityEngine;
using UnityEngine.Events;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private UnityEvent triggerEvent; 


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(GameplayManager.playerName))
        {
            triggerEvent?.Invoke();
        }
    }
}
