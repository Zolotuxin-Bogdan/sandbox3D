using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class TexturePackController: MonoBehaviour
    {
        public Button Done;

        private void Start() {
            Done.onClick.AddListener(Submit);
        }

        private void Submit()
        {
            action.Invoke();
        }
        private UnityAction action;
        public void AddListener(UnityAction action)
        {
            this.action = action;
        }
    }
}