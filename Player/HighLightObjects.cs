using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighLightObjects : MonoBehaviour
{
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;

    private Transform _selection;

    private void Update()
    {
        if (!GameAttributes.onPause)
        {
            if (_selection != null)
            {
                if (_selection.GetComponent<Renderer>())
                {
                    _selection.GetComponent<Renderer>().material = defaultMaterial;
                }
                if (_selection.childCount > 0)
                {
                    for (int i = 0; i < _selection.childCount; i++)
                    {
                        if (_selection.GetChild(i).GetComponent<Renderer>())
                        {
                            _selection.GetChild(i).GetComponent<Renderer>().material = defaultMaterial;
                        }
                    }
                }
                GameAttributes.lastLookingGameObject = _selection.transform.gameObject;
                _selection = null;
            }

            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                var selection = hit.transform;
                if (selection.GetComponent<GetItem>() && selection.GetComponent<GetItem>().item.usable)
                {
                    if (selection.GetComponent<Renderer>())
                    {
                        var selectionRenderer = selection.GetComponent<Renderer>();
                        if (selectionRenderer != null)
                        {
                            GameAttributes.activeLookingGameObject = selection.transform.gameObject;
                            selectionRenderer.material = highlightMaterial;
                        }
                    }
                    if (selection.childCount > 0)
                    {
                        for (int i = 0; i < selection.childCount; i++)
                        {
                            if (selection.GetChild(i).GetComponent<Renderer>())
                            {
                                selection.GetChild(i).GetComponent<Renderer>().material = highlightMaterial;
                            }
                        }
                    }

                    _selection = selection;
                }
            }
        }
    }
}
