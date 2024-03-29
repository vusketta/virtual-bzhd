using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorRayCasting : MonoBehaviour
{

    private const float TUMBLER_ANGLE = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void RotateTumbler(GameObject tumblerObject, int placesCount)
    {
        tumblerObject.transform.Rotate(Vector3.back, TUMBLER_ANGLE);

        Debug.Log(tumblerObject.transform.eulerAngles.z);

        if (tumblerObject.transform.eulerAngles.z - 360f < -placesCount * TUMBLER_ANGLE)
        {
            tumblerObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                
                InteractableType type = hit.transform.gameObject.GetComponent<ElementType>().elementType;
                switch(type)
                {
                    case InteractableType.TUMBLER:
                        RotateTumbler(hit.transform.gameObject, 7);
                        break;
                    case InteractableType.TUMBLER_FLOOR:
                        RotateTumbler(hit.transform.gameObject, 4);
                        break;
                    case InteractableType.TUMBLER_PROTECT:
                        RotateTumbler(hit.transform.gameObject, 9);
                        break;
                }
            }
        }
    }
}
