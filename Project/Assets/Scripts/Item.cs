using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Item : MonoBehaviour
{
    public Color originalColor;
    public Sprite tagImage;
    private void Start()
    {
        originalColor=GetComponent<Renderer>().material.color;
        itemObject = gameObject;

        itemName = itemObject.name;
    }
    [HideInInspector] public string itemName;
    [HideInInspector] public GameObject itemObject;
    
    

}
