using System.Collections.Generic;
using System.Linq;

namespace FiddlerSanitizer
{
    public class StringsPreferenceAccessor : AuthSanitizerPreferenceAccessor<IEnumerable<string>>
    {
        public override void Set(string key, IEnumerable<string> value) => Fiddler.FiddlerApplication.Prefs.SetStringPref(GetPropFullName(key), value != null ? string.Join(",", value) : null);

        public override IEnumerable<string> Get(string key) => Fiddler.FiddlerApplication.Prefs.GetStringPref(GetPropFullName(key), null)?.Split(',').Where(x => x != string.Empty);
    }
}
