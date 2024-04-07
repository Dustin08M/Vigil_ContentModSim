using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ClickAndDrag : MonoBehaviour
{
    private float StartPosX;
    private float StartPosY;
    private bool isBeingHeld = false;

    Vector2 difference = Vector2.zero;
    [SerializeField]private Canvas canvas;

    void Update()
    {
/*        if (isBeingHeld == true)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - StartPosX, mousePos.y - StartPosY, 0);
        }*/
    }

    private void OnMouseDown()
    {
/*        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Mouse Pressed");
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            StartPosX = mousePos.x - this.transform.localPosition.x;
            StartPosY = mousePos.y - this.transform.localPosition.y;

            isBeingHeld = true;
        }*/
        difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
    }

   /* private void OnMouseUp()
    {
        isBeingHeld = false;
    }*/

    private void OnMouseDrag()
    {
        transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
    }

    public void DragHandler(BaseEventData data)
    {
        PointerEventData pointerData = (PointerEventData)data;
        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle((RectTransform)canvas.transform, pointerData.position, canvas.worldCamera, out position);

        transform.position = canvas.transform.TransformPoint(position);
    }
}
