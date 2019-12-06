using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;
    public Text nameText;
    public Text descriptionText;
    public Text manaText;
    public Text attackText;
    public Text healthText;
    public Image artworkDisplay;

    // Start is called before the first frame update
    private void Start()
    {
        card.Print();

        nameText.text = card.name;
        descriptionText.text = card.description;
        manaText.text = card.manaCost.ToString();
        attackText.text = card.attack.ToString();
        healthText.text = card.health.ToString();
        artworkDisplay.sprite = card.artwork;
    }
}