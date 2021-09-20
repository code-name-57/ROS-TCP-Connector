using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Robotics.MessageVisualizers
{
    public interface IVisual
    {
        bool IsDrawingEnabled { get; }
        void SetDrawingEnabled(bool enabled);
        void Redraw();
        void OnGUI();
    }
}
