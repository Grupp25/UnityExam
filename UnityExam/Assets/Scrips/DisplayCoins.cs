using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCoins : MonoBehaviour
{
    
    private TMPro.TextMeshProUGUI title;
    
    private string displayedAmountCoins = "";

    public int amountCoins { get; set; } = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        title = GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        displayedAmountCoins = "" + amountCoins;

        title.text = displayedAmountCoins;
    }
}
