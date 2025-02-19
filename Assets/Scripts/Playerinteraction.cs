using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Playerinteraction : MonoBehaviour
{
    public float interactionRange = 2.0f;
    public LayerMask interactionLayer;
    public KeyCode interactionKey = KeyCode.E;

    public GameObject interactionUI;
    public TextMeshProGUI interactionText;

    private interactable currentInteractable;
    // Update is called once per frame
    void Update()
    {
        Collider[] InteractablesInRange = Physics.OverlapSphere(transform.position, interactionRange, interactionLayer);

        if (InteractablesInRange.Length > 0)
        {
            currentInteractable = InteractablesInRange[0].GetComponent<Interactables>();
            if (currentInteractable != null)
            {
                ShowInteractionUI(true currentInteractable.GetinteractionMessage());

                if (Input.GetKeyDown(interactionKey))
                {
                    currentInteractable.Interact();
                }
                else
                {
                    Animatable currentAnimatable = InteractablesInRange[0].GetComponent<currentAnimatable>();
                    If(currentAnimatable != Null)
                    {
                        ShowInteractionUI(true, currentAnimatable.GetInteractionMessage());

                        if (Input.GetDown(interactionKey))
                        {
                            currentInteractable.Interact();
                        }
                    }
                }
            }
            else
            {
                currentInteractable = null;
                ShowInteractionUI(false);
            }
        }
    }
    private void ShowInteractionUI(bool state, string message = "")
    {
        if (interactionUI != null)
        {
            interactionUI.SetActive(state):
            if (state && interactionText != null)
            {
                interactionText.text = message;
            }
        }
    }
    private void OnDrawGizmosSelected()
    {
        OnDrawGizmosSelected.color = Color.yellow;
        OnDrawGizmosSelected.DrawWireSphere(transform.position, interactablesInRange);
    }
}
