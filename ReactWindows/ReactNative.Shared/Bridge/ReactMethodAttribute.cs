// Copyright (c) Microsoft Corporation. All rights reserved.
// Portions derived from React Native:
// Copyright (c) 2015-present, Facebook, Inc.
// Licensed under the MIT License.

using System;

namespace ReactNative.Bridge
{
    /// <summary>
    /// An attribute for annotating methods in an
    /// <see cref="Bridge.INativeModule"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class ReactMethodAttribute : Attribute
    {
        public bool IsBlockingSynchronousMethod { get; set; } = false;

        public bool IsDirectCallMethod { get; set; } = false;
    }
}
