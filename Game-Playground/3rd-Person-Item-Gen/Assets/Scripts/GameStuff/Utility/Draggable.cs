using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/// <summary>
/// Utils to make items in inventory DraggableANDdroppable.
/// </summary>
/// /// TODO: Wire this up.

namespace GameStuff.Utility
{
    public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        public Transform parentToReturnTo;

        private GameObject placeholder;
        public Transform placeholderParent;

        public void OnBeginDrag(PointerEventData eventData)
        {
            Debug.Log("OnBeginDrag");

            placeholder = new GameObject();
            placeholder.transform.SetParent(transform.parent);
            var le = placeholder.AddComponent<LayoutElement>();
            le.preferredWidth = GetComponent<LayoutElement>().preferredWidth;
            le.preferredHeight = GetComponent<LayoutElement>().preferredHeight;
            le.flexibleWidth = 0;
            le.flexibleHeight = 0;

            placeholder.transform.SetSiblingIndex(transform.GetSiblingIndex());

            parentToReturnTo = transform.parent;
            placeholderParent = parentToReturnTo;
            transform.SetParent(transform.parent.parent);

            GetComponent<CanvasGroup>().blocksRaycasts = false;
        }

        public void OnDrag(PointerEventData eventData)
        {
            //Debug.Log ("OnDrag");

            transform.position = eventData.position;

            if (placeholder.transform.parent != placeholderParent)
                placeholder.transform.SetParent(placeholderParent);

            var newSiblingIndex = placeholderParent.childCount;

            for (var i = 0; i < placeholderParent.childCount; i++)
                if (transform.position.x < placeholderParent.GetChild(i).position.x)
                {
                    newSiblingIndex = i;

                    if (placeholder.transform.GetSiblingIndex() < newSiblingIndex)
                        newSiblingIndex--;

                    break;
                }

            placeholder.transform.SetSiblingIndex(newSiblingIndex);
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            Debug.Log("OnEndDrag");
            transform.SetParent(parentToReturnTo);
            transform.SetSiblingIndex(placeholder.transform.GetSiblingIndex());
            GetComponent<CanvasGroup>().blocksRaycasts = true;

            Destroy(placeholder);
        }
    }
}