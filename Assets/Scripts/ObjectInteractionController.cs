using UnityEngine;

public class ObjectInteractionController : MonoBehaviour
{
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main; // Ensure the main camera is tagged as "MainCamera"
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Checks if the left mouse button was clicked
        {
            RaycastForObjects();
        }
    }

    void RaycastForObjects()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100f)) // Casts the ray and get information on what was hit
        {
            Debug.Log("Hit " + hit.transform.name); // Logs what was hit

            Interactable interactable = hit.collider.GetComponent<Interactable>();
            if (interactable != null)
            {
                interactable.Interact();
            }
        }
    }
}
