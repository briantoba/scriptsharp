// ScaleOption.cs
// Script#/Libraries/jQuery/UI
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace jQueryApi.UI.Effects {

    /// <summary>
    /// Options for use with Scale.
    /// </summary>
    [Imported]
    [IgnoreNamespace]
    [NamedValues]
    public enum ScaleOption {

        /// <summary>
        /// A callback function, executed when the effect completes
        /// </summary>
        Complete,

        /// <summary>
        /// The direction of the effect. Can be "both", "vertical" or "horizontal".
        /// </summary>
        Direction,

        /// <summary>
        /// The number of ms the animation will run for
        /// </summary>
        Duration,

        /// <summary>
        /// The easing function to use
        /// </summary>
        Easing,

        /// <summary>
        /// The vanishing point, default for show/hide.
        /// </summary>
        Origin,

        /// <summary>
        /// The percentage to scale to.
        /// </summary>
        Percent,

        /// <summary>
        /// Which areas of the element will be resized: 'both', 'box', 'content' Box resizes the border and padding of the element Content resizes any content inside of the element
        /// </summary>
        Scale
    }
}
