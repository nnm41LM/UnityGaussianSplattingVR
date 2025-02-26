using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Meta.XR.BuildingBlocks;

public class LineCreater : MonoBehaviour
{
    [SerializeField] private GameObject _lineRendererPrefab;
    [SerializeField] private OVRHand _ovrHand;
    [SerializeField] private ControllerButtonsMapper _mapper;

    // ライン引き
    private GameObject _currentLineObject = null;
    private LineRenderer _lineRenderer;
    private List<GameObject> _manageLineObjectList = new List<GameObject>();

    void Start()
    {
        AddOVRInputEvent(
            _mapper,
            "RegistMarker",
            OVRInput.Button.Start,
            ControllerButtonsMapper.ButtonClickAction.ButtonClickMode.OnButtonDown,
            () => ClearLines(_lineRenderer)
            );
    }

    private void AddOVRInputEvent(
        ControllerButtonsMapper mapper,
        string title,
        OVRInput.Button buttonType,
        ControllerButtonsMapper.ButtonClickAction.ButtonClickMode buttonMode,
        UnityAction call
        )
    {
        var action = new ControllerButtonsMapper.ButtonClickAction();
        action.Title = title;
        action.Button = buttonType;// Primary: 左手、Secondary: 右手
        action.ButtonMode = buttonMode;
        var uEvent = new UnityEvent();
        uEvent.AddListener(call);
        action.Callback = uEvent;

        mapper.ButtonClickActions.Add(action);
    }

    private void ClearLines(LineRenderer lineRenderer)
    {
        lineRenderer.positionCount = 0;
        foreach (var obj in _manageLineObjectList)
        {
            GameObject.Destroy(obj);
        }
        _manageLineObjectList.Clear();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateLines();
    }

    private void UpdateLines()
    {
        if (_ovrHand.GetFingerIsPinching(OVRHand.HandFinger.Index) &&
            _ovrHand.GetFingerIsPinching(OVRHand.HandFinger.Thumb))
        {
            if (_currentLineObject == null)
            {
                _currentLineObject = Instantiate(_lineRendererPrefab, Vector3.zero, Quaternion.identity);
                _lineRenderer = _currentLineObject.GetComponent<LineRenderer>();
            }
            int nextPositionIndex = _lineRenderer.positionCount;
            _lineRenderer.positionCount = nextPositionIndex + 1;
            _lineRenderer.SetPosition(nextPositionIndex, _ovrHand.PointerPose.position);
        }
        else //線を書かない時の処理
        {
            if (_currentLineObject != null)
            {
                Debug.Log("書かない");
                _manageLineObjectList.Add(_currentLineObject);
                _currentLineObject = null;
            }
        }
    }
}
