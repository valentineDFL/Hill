using JetBrains.Annotations;
using UnityEngine;

namespace Assets.Scripts.Car
{
    public class Car : MonoBehaviour
    {
        [SerializeField] private MoveButtons _speedLeft;
        [SerializeField] private MoveButtons _speedRight;
        [SerializeField] private GameObject _startPoint;
        [SerializeField] private Camera _mainCamera;

        private float _margin = 7;
        [SerializeField] private float _maxRotate = 60;
        [SerializeField] private float _rotateSpeed = 60;


        private float _distanceScore;

        private Rigidbody2D _rb;

        private void Start()
        {
            _rb = GetComponentInChildren<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
            _mainCamera.transform.position = new Vector3(this.transform.position.x + this.transform.localScale.x * _margin, 0, -10);
            CountDistance();
            Move(_speedLeft, -_maxRotate);
            Move(_speedRight, _maxRotate);
        }

        private void CountDistance()
        {
            _distanceScore = Vector2.Distance(new Vector2(_startPoint.transform.position.x, 0), new Vector2(this.transform.position.x, 0));
            if (_distanceScore != PlayerPrefs.GetInt(GlobalVariables.DistanceKey))
            {
                PlayerPrefs.SetInt(GlobalVariables.DistanceKey, (int)_distanceScore);
            }
        }

        private void Move(MoveButtons buttonTurn, float rotateDegree)
        {
            if (buttonTurn.Flag)
            {
                _rb.transform.position += Vector3.right * buttonTurn.Speed * Time.fixedDeltaTime;
                _rb.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, Quaternion.Euler(0, 0, rotateDegree), _rotateSpeed * Time.fixedDeltaTime);
            }
        }

    }
}
