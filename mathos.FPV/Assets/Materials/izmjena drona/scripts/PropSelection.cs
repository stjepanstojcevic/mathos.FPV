using UnityEngine;
using UnityEngine.UI;

public class PropSelections : MonoBehaviour
{
    [SerializeField] private Button previousButton;
    [SerializeField] private Button nextButton;
    private int currentProp;

    private void Awake()
    {
        SelectCar(0);
    }

    private void SelectCar(int _index)
    {
        previousButton.interactable = (_index != 0);
        nextButton.interactable = (_index != transform.childCount-1);

        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == _index);
        }
    }

    public void ChangeCar(int _change)
    {
        currentProp += _change;
        SelectCar(currentProp);
    }
}
