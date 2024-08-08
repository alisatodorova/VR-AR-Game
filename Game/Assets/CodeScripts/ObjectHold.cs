using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHold : MonoBehaviour
{
    public List<GameObject> Object;
    public Transform PlayerTransform;
    public float range = 3f;
    public float Go = 100f;
    public Camera Camera;

    // Start is called before the first frame update
    void Start()
    {
        Object = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)) //Press key "p" to hold the object
        {
            StartPickUp();
        }
        if (Input.GetKeyUp(KeyCode.O)) //Press key "o" to drop the object
        {
            Drop(Object[Object.Count - 1]);
        }
    }

    void StartPickUp()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                PickUp(hit.transform.gameObject);
            }
        }
     }

    void PickUp(GameObject pickUpObject)
    {
        Object.Add(pickUpObject);
        pickUpObject.transform.SetParent(PlayerTransform);
    }

    void Drop(GameObject dropObject)
    {
        if (Object.Contains(dropObject))
        {
            Object.Remove(dropObject);
            dropObject.transform.SetParent(null);
        }
    }
}
