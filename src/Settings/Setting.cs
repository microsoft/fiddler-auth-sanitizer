using System;
using System.Collections.Generic;

namespace FiddlerSanitizer
{
    public class BoolSetting : NullableSetting<bool> { public BoolSetting(string key, bool defaultValue) : base(key, defaultValue, new BoolPreferenceAccessor()) { } }
    public class StringSetting : Setting<string> { public StringSetting(string key, string defaultValue) : base(key, defaultValue, new StringPreferenceAccessor()) { } }
    public class StringsSetting : Setting<IEnumerable<string>> { public StringsSetting(string key, IEnumerable<string> defaultValue) : base(key, defaultValue, new StringsPreferenceAccessor()) { } }

    public class NullableSetting<T> where T : struct
    {
        private readonly string key;
        private readonly T defaultValue;
        private readonly IPreferenceAccessor<T?> preferenceAccessor;

        public NullableSetting(string key, T defaultValue, IPreferenceAccessor<T?> preferenceAccessor)
        {
            this.key = key;
            this.defaultValue = defaultValue;
            this.preferenceAccessor = preferenceAccessor;
        }

        public T Value
        {
            get { var value = preferenceAccessor.Get(key); return value ?? defaultValue; }
            set => preferenceAccessor.Set(key, value);
        }
    }

    public class Setting<T>
    {
        private readonly string key;
        private readonly T defaultValue;
        private readonly IPreferenceAccessor<T> preferenceAccessor;

        public Setting(string key, T defaultValue, IPreferenceAccessor<T> preferenceAccessor)
        {
            this.key = key;
            this.defaultValue = defaultValue;
            this.preferenceAccessor = preferenceAccessor;
        }

        public T Value
        {
            get
            {
                var value = preferenceAccessor.Get(key);
                return !EqualityComparer<T>.Default.Equals(value, default(T)) ? value : defaultValue;
            }
            set => preferenceAccessor.Set(key, value);
        }
    }
}