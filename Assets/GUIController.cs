using Assets.Minerals;
using UnityEngine;
using UnityEngine.UI;


public class GUIController : MonoBehaviour
{

    [Range(0, 100)]
    public int AmountLead;

    public Button LeadButton;
    public Button AluminumButton;

    public Text LeadPrice;
    public Text AluminumPrice;


    // Use this for initialization
    void Start()
    {
        LeadPrice.text = "$ "+ Lead.Instance.CurrentValue.ToString("n2");
        AluminumPrice.text = "$ " + Aluminum.Instance.CurrentValue.ToString("n2");
    }

    // Update is called once per frame
    void Update()
    {
        LeadButton.GetComponent<Button>().interactable = !Lead.Instance.Weighing;
        AluminumButton.GetComponent<Button>().interactable = !Aluminum.Instance.Weighing;

        LeadPrice.text = "$ " + Lead.Instance.CurrentValue.ToString("n2");
        AluminumPrice.text = "$ " + Aluminum.Instance.CurrentValue.ToString("n2");
    }
}
