using UnityEngine;

public class FollowTrget : MonoBehaviour
{
    public Transform player;

    private void Update()
    {
        if (player.position.y > transform.position.y)
        {
            transform.position = new Vector3(0f, player.position.y, -10f);
        }
    }
}
