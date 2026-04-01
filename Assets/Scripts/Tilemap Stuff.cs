using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;



public class TilemapStuff : MonoBehaviour
{
    public Tilemap tilemap;
    public Transform highlight;

    public Tile flower;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the mouse position, and get the world point under that pixel
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //Asking what cell of the grid is under that position, and its giving me the bottom left corner of the cell
        Vector3Int cellPos = tilemap.WorldToCell(mousePos);
        //Asking what the center of that cell is in world space, and giving me that position
        Vector3 pos = tilemap.GetCellCenterWorld(cellPos);

        //Debug.Log(mousePos + " is over cell: " + cellPos);
        //setting the boba position to the center of the cell that the mouse is over
        highlight.position = pos;

        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            Debug.Log(tilemap.GetTile(cellPos));
            tilemap.SetTile(cellPos, flower);
        }


    }
}
