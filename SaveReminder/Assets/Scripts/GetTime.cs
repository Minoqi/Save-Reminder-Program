using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTime : MonoBehaviour
{
    //Variables
    private SpriteRenderer rend;
    private Color nonHighlightedColor;
    private Color highlightedColor;
    private Color selectedColor;
    public int value;
    public float hoverSize;
    public bool oppositeButton;

    // Start is called before the first frame update
    void Start()
    {
        rend = gameObject.GetComponent<SpriteRenderer>();
        nonHighlightedColor = new Color(39, 36, 44);
        highlightedColor = new Color(138, 138, 142);
        selectedColor = new Color(249, 249, 249);
        value = 0;
        hoverSize = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Mosue Over It
    private void OnMouseEnter()
    {
        transform.localScale += Vector3.one * hoverSize;
        //rend.color = new Color(138, 138, 142);
    }

    //Mouse Not Over It
    private void OnMouseExit()
    {
        transform.localScale -= Vector3.one * hoverSize;
        //rend.color = new Color(39, 36, 44);
    }

    //When Clicked Add 1 & Update Color
    private void OnMouseDown()
    {
        //rend.color = selectedColor;
        transform.localScale -= Vector3.one * hoverSize;
        value++;
        Debug.Log("Value: " + value);
    }

    //Reset
    private void OnMouseUp()
    {
        transform.localScale += Vector3.one * hoverSize;
        //rend.color = highlightedColor;
    }
}
