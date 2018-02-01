// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace FiddlerSanitizer
{
    public interface IPreferenceAccessor<T>
    {
        void Set(string key, T value);
        T Get(string key);
    }
}