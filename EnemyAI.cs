using UnityEngine;
public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float speed = 2f;
    void Update()
    {
        if(player) transform.position = Vector3.MoveTowards(transform.position, player.position, speed*Time.deltaTime);
    }
}