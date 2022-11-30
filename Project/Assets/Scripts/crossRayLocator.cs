
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public enum moveMode
{
    joystick,
    crossRay
}

public class crossRayLocator : MonoBehaviour
{
    public GameObject leftRay;

    public void crossSelect(GameObject selectedObject)
    {
        Vector3 targetPos = rayHitPos();
        if (targetPos != Vector3.zero)
        {
            selectedObject.transform.position = targetPos;
        }
    }
    Vector3 rayHitPos()         //获取右手发射射线和左手射线碰撞的点
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, out hit, 10))
        {
            if (hit.transform.gameObject == leftRay)
                return hit.point;
        }
        return Vector3.zero;
    }
}
