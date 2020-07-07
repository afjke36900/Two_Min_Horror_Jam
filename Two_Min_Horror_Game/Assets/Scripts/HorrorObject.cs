using UnityEngine;

public class HorrorObject : MonoBehaviour,ITriggerEvent
{
    public virtual void TriggerEvent() 
    {
        print("!");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "玩家") TriggerEvent();
    }
}
