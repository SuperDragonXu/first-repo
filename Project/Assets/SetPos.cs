using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPos : MonoBehaviour
{
    public float range = 35.55f;
    public Image parentImage;
    private void Start()
    {
        float theta=MathExtend.GetAngle(parentImage.fillAmount)/2;
        Vector2 localOffset= MathExtend.GetPoint_Reverse(theta, range);
        GetComponent<RectTransform>().localPosition=localOffset;
        transform.rotation= Quaternion.identity;    
  
    }

}

