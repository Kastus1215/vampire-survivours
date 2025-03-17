using System.Collections.Generic;
using UnityEngine;

public class CameraFix : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
    
    }

    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10f);
    }
}
