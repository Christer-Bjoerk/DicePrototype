using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class Dice : MonoBehaviour
{
    [SerializeField] private InputActionReference rollDiceAction;
    [SerializeField] private DiceDataScriptableObject diceData;
    [SerializeField] private float diceForce;

    private Rigidbody rb;

    private void OnEnable()
    {
        rollDiceAction.action.Enable();
    }

    private void OnDisable()
    {
        rollDiceAction.action.Disable();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        RollDice();
    }

    /// <summary>
    /// Roll the dice to get a number
    /// </summary>
    private void RollDice()
    {
        diceData.velocity = rb.velocity;

        if (rollDiceAction.action.triggered && IsDiceMoving())
        {
            ResetDice();

            float dirX = Random.Range(0, 500);
            float dirY = Random.Range(0, 500);
            float dirZ = Random.Range(0, 500);

            rb.AddForce(transform.up * diceForce);
            rb.AddTorque(dirX, dirY, dirZ);
        }
    }

    /// <summary>
    /// Check if the dice is moving
    /// </summary>
    /// <returns></returns>
    private bool IsDiceMoving()
    {
        return rb.velocity == new Vector3(0,0,0);
    }

    /// <summary>
    /// Reset to default values
    /// </summary>
    private void ResetDice()
    {
        EventManager.onRollingDice?.Invoke(0);
        // Reset the dice position & rotation
        transform.SetPositionAndRotation(new Vector3(0, 2, 0), Quaternion.identity);

        diceData.isDiceMoving = true;
    }
}