using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler
{
    public string allowedTag = "Comida";
    public void OnDrop(PointerEventData eventData)
    {
        GameObject draggedObject = eventData.pointerDrag;

        if (transform.childCount == 0 && draggedObject.tag == allowedTag)
        {
                GameObject dropped = eventData.pointerDrag;
                DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
                draggableItem.parentAfterDrag = transform;
                StartCoroutine(FlashSlot());

        }

    }
    IEnumerator FlashSlot()
    {
        Image slotImage = GetComponent<Image>();
        Color originalColor = slotImage.color;

        slotImage.color = Color.green;  // Cambiar el color a verde

        yield return new WaitForSeconds(0.3f);  // Esperar 0.3 segundos

        slotImage.color = originalColor;  // Restaurar el color original
    }
}
