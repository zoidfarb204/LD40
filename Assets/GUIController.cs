using Assets.Minerals;
using Assets.People;
using Assets.Player;
using NUnit.Framework.Api;
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

    public Text LeadStock;
    public Text AluminumStock;

    public Image[] cards;



    public string TestText;

    // Use this for initialization
    void Start()
    {
        LeadPrice.text = "$ "+ Lead.Instance.CurrentValue.ToString("n2");
        AluminumPrice.text = "$ " + Aluminum.Instance.CurrentValue.ToString("n2");

        LeadStock.text = Player.Instance.Lead.ToString();
        AluminumStock.text = Player.Instance.Aluminum.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        LeadButton.GetComponent<Button>().interactable = !Lead.Instance.Weighing;
        AluminumButton.GetComponent<Button>().interactable = !Aluminum.Instance.Weighing;

        LeadPrice.text = "$ " + Lead.Instance.CurrentValue.ToString("n2");
        AluminumPrice.text = "$ " + Aluminum.Instance.CurrentValue.ToString("n2");

        LeadStock.text = Player.Instance.Lead.ToString();
        AluminumStock.text = Player.Instance.Aluminum.ToString();

        int card = 0;
        if (Person.People != null)
        {
         card = Person.People.Count;
        }
        TestText = card.ToString();

        int count = 1;
        foreach (var image in cards)
        {
            if (count <= card)
            {
                image.enabled = true;
            }
            else
            {
                image.enabled = false;
            }
            count++;
        }

    }
}
