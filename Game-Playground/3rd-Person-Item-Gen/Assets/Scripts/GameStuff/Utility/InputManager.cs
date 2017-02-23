using GameStuff.Utility;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public bool isAlive = true;
    public GameObject window;

    // Use this for initialization
    private void Start()
    {
        Debug.Log("isAlive=" + isAlive.ConvertBoolToString());
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.I))
            window.ToggleGameObject();
    }
}