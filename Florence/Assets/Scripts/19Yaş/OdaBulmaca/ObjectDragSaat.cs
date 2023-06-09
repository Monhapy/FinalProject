using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDragSaat : MonoBehaviour
{
    public GameObject targetObject, b�rak�lan, ortaya��kan; // �st�ne b�rak�lacak obje


    private bool isDragging = false;
    private Vector3 offset;
    

    private void OnMouseDown()
    {
        offset = gameObject.transform.position - GetMouseWorldPosition();
        isDragging = true;
    }

    private void OnMouseUp()
    {
        if (targetObject != null && isDragging)
        {
            b�rak�lan.SetActive(false);
            
            ortaya��kan.SetActive(true);
        }
        isDragging = false;
    }

    private void Update()
    {
        
        if (isDragging)
        {
            Vector3 mousePos = GetMouseWorldPosition();
            transform.position = new Vector3(mousePos.x + offset.x, mousePos.y + offset.y, transform.position.z);
        }
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -Camera.main.transform.position.z;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }
}
