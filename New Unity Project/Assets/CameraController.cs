using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Grid grid;
    // Start is called before the first frame update
    void Start()
    {
        grid = new Grid(20, 5, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grid.SetValue(GetMouseWorldPosition(), Random.Range(1,20));
        }

        if (Input.GetMouseButtonDown(1))
        {
           Debug.Log(grid.GetValue(GetMouseWorldPosition()));
            
        }
    }
    public static Vector3 GetMouseWorldPosition()
    {
        Vector3 worldPosition = GetMouseWorldPosition(Input.mousePosition, Camera.main);
        //worldPosition.z = 0f;
        Debug.Log(worldPosition);
        return worldPosition;
    }
    public static Vector3 GetMouseWorldPosition(Vector3 screenPosition, Camera worldCamera)
    {
        Vector3 worldPosition = worldCamera.ScreenToWorldPoint(screenPosition);
        return worldPosition;
    }
}
