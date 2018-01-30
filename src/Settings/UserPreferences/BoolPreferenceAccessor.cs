using System;

namespace FiddlerSanitizer
{
    public class BoolPreferenceAccessor : AuthSanitizerPreferenceAccessor<Nullable<bool>>
    {
        public override void Set(string key, bool? value) => Fiddler.FiddlerApplication.Prefs.SetStringPref(GetPropFullName(key), value?.ToString());

        public override bool? Get(string key)
        {
            // Fiddler has GetBoolPref but it isn't nullable
            if (bool.TryParse(Fiddler.FiddlerApplication.Prefs.GetStringPref(GetPropFullName(key), null), out bool result))
            {
                return result;
            }

            return null;
        }
    }
}