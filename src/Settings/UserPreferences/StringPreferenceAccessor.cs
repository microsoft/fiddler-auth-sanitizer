namespace FiddlerSanitizer
{
    public class StringPreferenceAccessor : AuthSanitizerPreferenceAccessor<string>
    {
        public override void Set(string key, string value) => Fiddler.FiddlerApplication.Prefs.SetStringPref(GetPropFullName(key), value);

        public override string Get(string key) => Fiddler.FiddlerApplication.Prefs.GetStringPref(GetPropFullName(key), null);
    }
}