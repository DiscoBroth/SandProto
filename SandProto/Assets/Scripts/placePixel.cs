using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placePixel : MonoBehaviour
{

    enum pixelPallete
    {
        sand,
        rock,
        water
    }

    public GameObject pixel;
    pixelPallete selectedPixel = pixelPallete.sand;

    void spawnPixel(pixelPallete inPixel)
    {
        Camera camera = GetComponent<Camera>();
        Vector3 placementCoordinate = Camera.main.ScreenToWorldPoint(Input.mousePosition); //(position translated from screen to world point)
        placementCoordinate.z = 0; // Set z at 0 so camera can see it
        GameObject pixelObj = Object.Instantiate(pixel, placementCoordinate, new Quaternion()); // Spawn pixel, at mouse position, with 0 rotation.
        //pixelObj.pixelType = inPixel; // Tell the pixel what type it is.
    }

    void Update()
    {
        // Place pixel:
        if (Input.GetMouseButtonDown(0))
            spawnPixel(selectedPixel);
    }
}
