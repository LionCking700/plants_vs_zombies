using UnityEngine;
using UnityEngine.Events;

public class GunCreator : MonoBehaviour
{
    [SerializeField]

    private float raycastDistance = 100f;
    [SerializeField]

    private LayerMask targetlayer;
    [SerializeField]

    private string stepTag = "Step";

    private Tranform objectToPlace;

    private bool objectPlaced = false;

    private void Update()
    {
        if (objectToPlace == null) return;
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo, raycastDistance, targetLayer))
            {
                if (hitInfo.collider.CompareTag(stepTag))
                {
                    currentstep = hitInfo.collider.GetComponent<stepTag>();
                    objectToPlace.position = hitInfo.collider.transform.position;
                    objectPlaced = true;
                }
                else
                {
                    if(hitInfo.collider.CompareTag("floor"))
                    {
                    objectPlaced.position = hitInfo.point;
                }
            }

        }
        if (Input.GetMouseButtonUp(0))
        {
            if (!objectPlaced || currentStep == null || currentStep.IsOccupied)
            {
                objectToPlace.gameObject.SetActive(false);
            }
            else
            {
                currentStep.IsOccupied = true;
            }
            objectToPlace = null;

        }
    }
    public void SetObjectToPlace(Transform objTransform)
    {
        objectToPlace = objTransform;
        objectPlaced = false;
        currentStep = null;
    }
}
