using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ButtonController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [Serializefield]

    public UnityEvent onButtonDown;
    [Serializefield]

    public UnityEvent onButtonUp;

    public void OnPointerDown(PointerEvenData evenData)
    {
        onButtonDown?.Invoke();
    }

    public void OnPointerUp(PointerEventData evenData)
    {
        onButtonDown?.Invoke();
    }

    public void OnPointerUp(PointerEvenData eventData)
    {
        onButtonUp?.invoke();
    }
}
