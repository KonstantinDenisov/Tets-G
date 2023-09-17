using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class DraggableItem: MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler
    {
        [HideInInspector] public Transform _parenAfterDrag;
        [SerializeField] private Image _image;
        
        public void OnBeginDrag(PointerEventData eventData)
        {
            _parenAfterDrag = transform.parent;
            transform.SetParent(transform.root);
            transform.SetAsLastSibling();
            _image.raycastTarget = false;
        }

        public void OnDrag(PointerEventData eventData)
        {
            transform.position = Input.mousePosition;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            Debug.Log("End Drag");
            transform.SetParent(_parenAfterDrag);
            _image.raycastTarget = true;
        }
    }
