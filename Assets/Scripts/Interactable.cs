using UnityEngine;

public class Interactable : MonoBehaviour
{
    public string customMessage;

    public string GetInteractionMessage()
    {
        return string.IsNullOrEmpty(customMessage) ? "Interagir com" + gameObject.name
    }
    public void Interact()
    {
        Debug.Log($"Ineragiu com {gameObject.name}");
    }
}
