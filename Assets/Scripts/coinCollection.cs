using UnityEngine;

public class coinCollection : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D trigger)
    {
        if (trigger.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}
