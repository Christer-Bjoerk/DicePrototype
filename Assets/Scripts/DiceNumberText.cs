using TMPro;
using UnityEngine;

public class DiceNumberText : MonoBehaviour
{
    [SerializeField] private DiceDataScriptableObject diceData;
    [SerializeField] private TMP_Text diceNumberText;

    private void OnEnable()
    {
        EventManager.onRollingDice += UpdateDiceNumberText;
    }

    private void OnDisable()
    {
        EventManager.onRollingDice -= UpdateDiceNumberText;
    }

    private void Start()
    {
        diceNumberText = GetComponent<TMP_Text>();
    }

    public void UpdateDiceNumberText(int number)
    {
        diceNumberText.text = number.ToString();
    }
}