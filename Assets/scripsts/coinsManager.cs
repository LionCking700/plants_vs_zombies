using UnityEngine;

public class coinsManager : MonoBehaviour
{
    [SerializeField]

    private UnityEvent<int> onCoinsChanged;

    private int numberOfCoins = 0;

    public void SetNumberOfCoins(int amount)
    {
        numberOfCoins = amount;

        onCoinsChanged.Invoke(numberOfCoins);
    }
    public bool CanBuy(int Cost)
    {
        if (numberOfCoins >= cost)
        {
            SetNumberOfCoins(numberOfCoins - cost);
            return true;
        }
        return false;
    }
    public void AddCoins(int amount)
{
    SetNumberOfCoins(int amount)
}

}
