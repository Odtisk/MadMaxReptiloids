using UnityEngine;
using DG.Tweening;

public class DirectionPointer : MonoBehaviour
{
    private float _spinningTime = 10;
    private float _fullRotation = 360;
    private Tween _tween;

    private void Start()
    {
        float minRotation = _fullRotation;
        float maxRotation = _fullRotation * 3;
        float rotation = Random.Range(minRotation, maxRotation);

        _tween = transform.DORotate(Vector3.up * rotation, _spinningTime, RotateMode.LocalAxisAdd).SetEase(Ease.InOutQuad);
        _tween.SetLoops(-1, LoopType.Yoyo);
    }
}
