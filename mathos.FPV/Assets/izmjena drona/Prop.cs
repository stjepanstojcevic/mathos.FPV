using UnityEngine;
using UnityEngine.UI;

public class Prop: MonoBehaviour
{
    [SerializeField] private Button previousProp;
    [SerializeField] private Button nextProp;
    private int currentProp;

    private void Awake()
    {
        SelectCar(0);
    }

    private void SelectCar(int _index)
    {
        previousProp.interactable = (_index != 0);
        nextProp.interactable = (_index != transform.childCount-1);

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
