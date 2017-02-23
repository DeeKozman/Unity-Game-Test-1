﻿using UnityEngine;

namespace GameStuff.UI
{
    public class UIDirectionControl : MonoBehaviour
    {
        private Quaternion m_RelativeRotation; // The local rotatation at the start of the scene.

        /// This class is used to make sure world space UI
        /// elements such as the health bar face the correct direction.
        public bool m_UseRelativeRotation = true; // Use relative rotation should be used for this gameobject?


        private void Start()
        {
            m_RelativeRotation = transform.parent.localRotation;
        }


        private void Update()
        {
            if (m_UseRelativeRotation)
                transform.rotation = m_RelativeRotation;
        }
    }
}