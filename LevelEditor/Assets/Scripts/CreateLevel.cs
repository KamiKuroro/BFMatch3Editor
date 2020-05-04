using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateLevel : MonoBehaviour
{

#pragma warning disable 649
    [SerializeField]
    private Text selectedBrush;
    [SerializeField]
    private Dropdown brushTypeDropdown;
    [SerializeField]
    private Dropdown selectedBrushDropdown;
#pragma warning disable 649

    private List<Dropdown.OptionData> brushOptions;
    private List<string> brushTypeList = new List<string>();
    private string[] candyArr = { "Blue Candy", "Green Candy", "Orange Candy", "Purple Candy", "Red Candy", "Yellow Candy", "Random Candy" };
    private string[] elementArr = { "Honey", "Ice", "Syrup 1", "Syrup 2" };
    private string[] specialBlockArr = { "Marshmallow", "Chocolate", "Unbreakable" };
    private string[] collectableArr = { "Cherry", "Watermelon" };
    private string[] specialCandyArr = {
        "Blue Candy Horizontal Striped",
        "Green Candy Horizontal Striped",
        "Orange Candy Horizontal Striped",
        "Purple Candy Horizontal Striped",
        "Red Candy Horizontal Striped",
        "Yellow Candy Horizontal Striped",
        "Blue Candy Vertical Striped",
        "Green Candy Vertical Striped",
        "Orange Candy Vertical Striped",
        "Purple Candy Vertical Striped",
        "Red Candy Vertical Striped",
        "Yellow Candy Vertical Striped",
        "Blue Candy Wrapped",
        "Green Candy Wrapped",
        "Orange Candy Wrapped",
        "Purple Candy Wrapped",
        "Red Candy Wrapped",
        "Yellow Candy Wrapped",
        "Color Bomb",
    };

    private Dictionary<int, string[]> dictBrush = new Dictionary<int, string[]>();


    public void Start()
    {
        //brushOptions = brushTypeDropdown.GetComponent<Dropdown>().options;
        brushOptions = brushTypeDropdown.options;
        foreach (Dropdown.OptionData option in brushOptions)
        {
            brushTypeList.Add(option.text);
        }
        // set default Brush Type to "Candy"
        selectedBrush.text = "Candy";

        selectedBrushDropdown.options.Clear();
        // set default Selected Brush dropdown to Brush Type "Candy"
        foreach (string option in candyArr)
        {
            selectedBrushDropdown.options.Add(new Dropdown.OptionData() { text = option });
        }

        // init Brush Dictionary
        dictBrush.Add(0, candyArr);
        dictBrush.Add(1, elementArr);
        dictBrush.Add(2, specialCandyArr);
        dictBrush.Add(3, specialBlockArr);
        dictBrush.Add(4, collectableArr);
    }

    public void SetBrushtype(int val)
    {   
        selectedBrush.text = brushTypeList[val];
        selectedBrushDropdown.options.Clear();
        foreach (string option in dictBrush[val]) {
            selectedBrushDropdown.options.Add(new Dropdown.OptionData() { text = option });
        }
    }

}
