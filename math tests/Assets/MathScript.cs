using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathScript : MonoBehaviour
{
    public Transform A;
    public Transform B;

    public float scProj;
    void OnDrawGizmos()
    {
        Vector2 a = A.position;
        Vector2 b = B.position;

        Gizmos.color = Color.red;
        Gizmos.DrawLine(default, a);
        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(default, b);

        // normalizing A and drawing it

        // manual version
        // float aLength = a.magnitude;
        // float aLength = Mathf.Sqrt(a.x * a.x + a.y * a.y); //slightly faster than magnitude
        // Vector2 aNorm = a / aLength; // normalizing

        // quick and easy version
        Vector2 aNorm = a.normalized;

        Gizmos.color = Color.red;
        Gizmos.DrawSphere(aNorm, 0.05f);

        // Scalar projection
        scProj = Vector2.Dot(aNorm, b);

        // Vector projection
        Vector2 vecProj = aNorm * scProj;
        Gizmos.color = Color.white;
        Gizmos.DrawSphere(vecProj, 0.05f);


    }

}
