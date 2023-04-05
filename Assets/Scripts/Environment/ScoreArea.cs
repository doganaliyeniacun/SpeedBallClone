using UnityEngine;


public class ScoreArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(GameplayManager.playerName))
        {
            GameplayManager.instance.IncrementScore();
        }
    }
}
