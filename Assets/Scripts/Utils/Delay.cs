using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class Delay : MonoBehaviour
{
    private float counter;

    public bool Execute(float delayTime)
    {
        counter += Time.deltaTime;
        if (counter >= delayTime)
        {
            counter = 0f;
            return true;
        }
        else
        {
            return false;
        }
    }
}
