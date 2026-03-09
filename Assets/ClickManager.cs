using Unity.VisualScripting;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;

        //    if (Physics.Raycast(ray, out hit, 1000))
        //    {
        //        if (hit.collider.tag == "Trigger")
        //        {
        //            animator.enabled = false;
        //        }
        //    }
        //}
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.enabled = false;
        }
    }
}
