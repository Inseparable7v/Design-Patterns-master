﻿namespace ColorCloning
{
    using System.Collections.Generic;

    using ColorCloning.Models;

    /// <summary>
    ///  Prototype manager
    /// </summary>
    public class ColorManager
    {
        private readonly Dictionary<string, ColorPrototype> colors = new Dictionary<string, ColorPrototype>();

        public ColorPrototype this[string key]
        {
            get => colors[key];
            set => colors[key] = value;
        }
    }
}
