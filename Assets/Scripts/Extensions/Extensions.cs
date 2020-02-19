using UnityEngine;

public static class QuaternionExtension
{
    public static Quaternion IsolateYRotation(this Quaternion q)
    {
        return Quaternion.Euler(0, q.eulerAngles.y, 0);
    }
}
