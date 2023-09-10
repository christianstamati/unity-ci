using UnityEngine;
using UnityEngine.UIElements;

namespace CH.UnityCI
{
    public class UICounter : MonoBehaviour
    {
        [SerializeField] private UIDocument document;
        [SerializeField] private int count;
        private Label _countLabel;
        private Button _countButton;
        
        private void Awake()
        {
            var root = document.rootVisualElement;
            _countLabel = root.Q<Label>("Count");
            _countButton = root.Q<Button>("CountButton");
        }

        private void OnEnable()
        {
            _countButton.clicked += OnButtonPressed;
        }

        private void OnDisable()
        {
            _countButton.clicked -= OnButtonPressed;
        }
        
        private void OnButtonPressed()
        {
            count++;
            _countLabel.text = count.ToString();
        }
    }
}
