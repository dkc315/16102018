using UnityEngine;
using UnityEngine.Events;

public class MouseEventBehaviour : MonoBehaviour
{
    public UnityEvent MouseDown;
    public UnityEvent MouseUp;
    public UnityEvent MouseDrag;

    private void OnMouseDown()
    {
        MouseDown.Invoke();
    }

    private void OnMouseUp()
    {
        MouseUp.Invoke();
    }

    private void OnMouseDrag()
    {
        MouseDrag.Invoke();
    }
    
}

