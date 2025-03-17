using UnityEngine;

public class ButtonTrigger2 : MonoBehaviour
{

    public PlayerControl player;
    void OnTriggerEnter2D(Collider2D obj)
    {
        player.currHealth -= 10f;
        Destroy(gameObject);
    }
}
