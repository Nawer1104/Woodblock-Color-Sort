using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision != null && collision.gameObject.GetComponent<Tower>() != null)
        {
            if (collision.gameObject.GetComponent<Tower>().objectList.Contains(this)) return;

            if (collision.gameObject.GetComponent<Tower>().objectList.Count < 4)
            {
                GetComponent<DragAndDrop>()._dragging = false;

                collision.gameObject.GetComponent<Tower>().AddObject(this);
                return;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision != null && collision.gameObject.GetComponent<Tower>() != null)
        {
            collision.gameObject.GetComponent<Tower>().RemoveObject(this);
        }
    }
}
