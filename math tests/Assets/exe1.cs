using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exe1 : MonoBehaviour
{
    public Transform bomb;
    public Transform player;
    [SerializeField]
    private float distance;

    void Update()
    {
        // if (distance <= 5)
        // {
        //     Debug.Log("Explodiu!");
        // }
    }

    void OnDrawGizmos()
    {
        Vector2 bombVec = bomb.position;
        Vector2 playerVec = player.position;

        distance = Mathf.Sqrt(Mathf.Abs((bombVec.x * bombVec.x + bombVec.y * bombVec.y) - (playerVec.x * playerVec.x + playerVec.y * playerVec.y)));
        if (distance <= 5)
        {
            Debug.Log("Explodiu!");
        }
    }
}
