using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tooltip : MonoBehaviour
{
    public TextMeshProUGUI tooltipText;  // Campo para mostrar la información del objeto
    public GameObject tooltipPanel;  // Panel del Tooltip

    private void Start()
    {
        tooltipPanel.SetActive(false);  // Ocultar el tooltip al iniciar
    }

    // Mostrar el Tooltip con la información del objeto
    public void ShowTooltip(string content)
    {
        tooltipText.text = content;
        tooltipPanel.SetActive(true);
    }

    // Ocultar el Tooltip
    public void HideTooltip()
    {
        tooltipPanel.SetActive(false);
    }
}
