using UnityEngine;

public class ItemInteractioner : MonoBehaviour
{
    public Material defaultRendering, selectedRendering;
    protected Renderer RenderEngine;
    public GameObject selectedItem;
    protected Rigidbody selectedItemRB;
    protected Transform selectedItemTF;
    protected bool isSelected = false;
    protected Vector3 mousePos;
    void Start()
    {
        RenderEngine = GetComponent<Renderer>();
        selectedItemRB = GetComponent<Rigidbody>();
        selectedItemTF = GetComponent<Transform>();
    }
    private void OnMouseEnter()
    {
        isSelected = true;
        // Debug.Log("Mouse enter at item");
        RenderEngine.material = selectedRendering;
    }
    private void OnMouseExit()
    {
        isSelected = false;
        // Debug.Log("Mouse exit at item");
        RenderEngine.material = defaultRendering;
    }

    void FixedUpdate()
    {
        // mousePos = Input.mousePosition;

        if (Input.GetMouseButton(0) && isSelected == true)
        {
            // selectedItemTF.SetPositionAndRotation(mousePos, selectedItemTF.rotation);
            selectedItemRB.AddForce(0.0f, 10.0f, 0.0f, ForceMode.Impulse);
        }
    }

    // void Update() {}
}
