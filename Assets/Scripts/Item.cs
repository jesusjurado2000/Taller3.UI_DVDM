using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public string itemDescription;  // Descripci�n o detalles del objeto
    private Tooltip tooltip;

    private void Start()
    {
        // Obtener referencia al tooltip
        tooltip = FindObjectOfType<Tooltip>();
    }

    // Mostrar el tooltip al pasar el rat�n sobre el objeto
    public void OnPointerEnter(PointerEventData eventData)
    {
        tooltip.ShowTooltip(itemDescription);
    }

    // Ocultar el tooltip cuando el rat�n sale del objeto
    public void OnPointerExit(PointerEventData eventData)
    {
        tooltip.HideTooltip();
    }
}
