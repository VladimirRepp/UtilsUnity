using TMPro;
using UnityEngine;

// Изменять положение RectTransform (самая простая прокрутка)
//
// Иерархия:
// Canvas   
// └── Panel (Mask)
//     └── Text (TMP_Text)
// У Panel желательно добавить компонент Rect Mask 2D, 
// чтобы текст скрывался за границами панели.
//
// Плюсы:
// очень простой;
// практически без затрат;
// подходит в большинстве случаев.
public class ScrolledText : MonoBehaviour
{
    [SerializeField] private RectTransform textTransform;
    [SerializeField] private float speed = 100f;

    private float _startX;
    private float _endX;

    private void Start()
    {
        RectTransform parent = textTransform.parent as RectTransform;

        _startX = parent.rect.width;
        _endX = -textTransform.rect.width;

        textTransform.anchoredPosition =
            new Vector2(_startX, textTransform.anchoredPosition.y);
    }

    private void Update()
    {
        Vector2 pos = textTransform.anchoredPosition;
        pos.x -= speed * Time.deltaTime;

        if (pos.x < _endX)
            pos.x = _startX;

        textTransform.anchoredPosition = pos;
    }
}