using UnityEngine;

public class PlayerReset : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Lava")
        {
            transform.position = new Vector2(-7, -1);
        }
    }

}
