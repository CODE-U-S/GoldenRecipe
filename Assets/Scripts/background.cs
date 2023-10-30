using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;


public class background : MonoBehaviour
{

    [SerializeField]
    
    public void OnPointerClick(PointerEventData eventData)
    {
        
    }
        // Update is called once per frame
    void Update()
    {
    }
    /*public void movebackground()
    {
        float Left = Input.GetAxisRaw("Horizontal");
        Vector3 moveTo = new Vector3(Left, 0f, 0f);
        transform.position += moveTo * moveSpeed * Time.deltaTime;
        
    }*/
}
