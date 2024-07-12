using UnityEngine;
using UnityEngine.EventSystems;

public class MoveButtons : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private GameObject _car;
    [SerializeField] private float _speed;

    public float Speed => _speed;

    public bool Flag {  get; private set; }

    public void OnPointerDown(PointerEventData poi)
    {
        Flag = true;
    }

    public void OnPointerUp(PointerEventData poi)
    {
        Flag = false;
    }
}
