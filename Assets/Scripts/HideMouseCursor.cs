using UnityEngine;

public class HideMouseCursor : MonoBehaviour
{
    void Start()
    {
        // Initially hide and lock the cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Continuously hide and lock the cursor in case it becomes visible again
        if (Cursor.visible != false || Cursor.lockState != CursorLockMode.Locked)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        
        // Optional: Unlock the cursor for debugging with Escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}