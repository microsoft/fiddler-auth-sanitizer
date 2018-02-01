// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace FiddlerSanitizer
{
    public static class AuthSanitizerPreferenceConstants
    {
        public const string AuthSanitizerKeyRoot = "authsanitizer";
    }

    public abstract class AuthSanitizerPreferenceAccessor<T> : IPreferenceAccessor<T>
    {
        protected static string GetPropFullName(string prop) => $"{AuthSanitizerPreferenceConstants.AuthSanitizerKeyRoot}.{prop}";
        public abstract void Set(string key, T value);
        public abstract T Get(string key);
    }
}