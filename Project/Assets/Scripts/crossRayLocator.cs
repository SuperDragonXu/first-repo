
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
    Vector3 rayHitPos()         //��ȡ���ַ������ߺ�����������ײ�ĵ�
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
