using UnityEngine;

public class DiceCheckZone : MonoBehaviour
{
    [SerializeField] private DiceDataScriptableObject diceData;
    private int diceNumber;

    private void OnTriggerStay(Collider other)
    {
        // Only update the text if the dice is completely still
        if (diceData.velocity == new Vector3(0,0,0))
        {
            // Display the opposite number based on the side it lands on
            switch (other.gameObject.name)
            {
                case "Side1":
                    diceNumber = 6;
                    EventManager.onRollingDice?.Invoke(diceNumber);
                    break;

                case "Side2":
                    diceNumber = 5;
                    EventManager.onRollingDice?.Invoke(diceNumber);
                    break;

                case "Side3":
                    diceNumber = 4;
                    EventManager.onRollingDice?.Invoke(diceNumber);
                    break;

                case "Side4":
                    diceNumber = 3;
                    EventManager.onRollingDice?.Invoke(diceNumber);
                    break;

                case "Side5":
                    diceNumber = 2;
                    EventManager.onRollingDice?.Invoke(diceNumber);
                    break;

                case "Side6":
                    diceNumber = 1;
                    EventManager.onRollingDice?.Invoke(diceNumber);
                    break;

                default:
                    diceNumber = 0;
                    EventManager.onRollingDice?.Invoke(diceNumber);
                    break;
            }
        }
    }
}