using UnityEngine;

public class coinCollection : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerStay2D(Collider2D trigger)
    {
        if (trigger.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}
