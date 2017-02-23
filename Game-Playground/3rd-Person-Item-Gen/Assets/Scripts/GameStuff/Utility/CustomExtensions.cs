using UnityEngine;

namespace GameStuff.Utility
{
    public static class CustomExtensions
    {
        public static void ToggleGameObject(this GameObject _gameObject)
        {
            // ReSharper disable once ConvertIfStatementToConditionalTernaryExpression
            if (!_gameObject.activeSelf)
                _gameObject.SetActive(true);
            else
                _gameObject.SetActive(false);
        }

        public static string ConvertBoolToString(this bool value)
        {
            return !value ? "No" : "Yes";
        }
    }
}