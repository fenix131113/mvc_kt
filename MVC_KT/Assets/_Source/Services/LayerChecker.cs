﻿using UnityEngine;

namespace Services
{
    public class LayerChecker
    {
        public static bool CheckLayersEquality(LayerMask objectLayer, LayerMask requiredLayer) =>
            ((1 << objectLayer) & requiredLayer) > 0;
    }
}