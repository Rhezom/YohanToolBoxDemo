using System.Runtime.CompilerServices;
using UnityEngine;

public static class Vector3Extension
{
    public static void GetDistanceOptimized(this Vector3 firstPosition, Vector3 secondPosition, out float distance)
    {
        Vector3 heading;
        float distanceSquared = 0f;

        heading.x = firstPosition.x - secondPosition.x;
        heading.y = firstPosition.y - secondPosition.y;
        heading.z = firstPosition.z - secondPosition.z;

        distanceSquared = heading.x * heading.x + heading.y * heading.y + heading.z * heading.z;
        distance = Mathf.Sqrt(distanceSquared);
    }
}
