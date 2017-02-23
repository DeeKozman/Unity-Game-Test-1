using UnityEngine;
using UnityEngine.UI;

/// <summary>
///     TODO: Add this menu in for testing different resolutions. Not currently being used.
/// </summary>
public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject buttonPrefab;

    [SerializeField] private Transform menuPanel;

    private Resolution[] resolutions;

    // Use this for initialization
    private void Start()
    {
        resolutions = Screen.resolutions;
        for (var i = 0; i < resolutions.Length; i++)
        {
            var button = Instantiate(buttonPrefab);
            button.GetComponentInChildren<Text>().text = ResToString(resolutions[i]);
            var index = i;
            button.GetComponent<Button>().onClick.AddListener(
                () => { SetResolution(index); }
            );
            button.transform.parent = menuPanel;
        }
    }

    private void SetResolution(int index)
    {
        Screen.SetResolution(resolutions[index].width, resolutions[index].height, false);
    }

    private string ResToString(Resolution res)
    {
        return res.width + " x " + res.height;
    }
}