using UnityEngine;

public class Health : MonoBehaviour
{
    public PlayerControl player;
    void Update()
    {
        float healthPercent = (player.currHealth / player.maxHealth) * 1f;
        float healthLevel = healthPercent / 0.5f;
        transform.localScale = new Vector3(healthLevel,2f,1f);
        transform.position = new Vector3(player.transform.position.x+0.15f, player.transform.position.y + 2f, transform.position.z);
    }
}
