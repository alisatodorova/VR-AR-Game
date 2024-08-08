using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    public GameObject myGameObject;
    public string customText;
    public TextMeshProUGUI myText;
    
    void OnMouseEnter()
    {
        myText.text = customText;
        myText.transform.position = Camera.main.WorldToScreenPoint(myGameObject.transform.position);
    }

    void OnMouseExit()
    {
        myText.text = "";
    }
}
