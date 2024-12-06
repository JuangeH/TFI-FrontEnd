using InnoviaReach___TFI___FrontEnd.Resources;
using Microsoft.Extensions.Localization;
using System.Globalization;

namespace InnoviaReach___TFI___FrontEnd.Services
{
    public class LocalizationService
    {
        private readonly IStringLocalizer<Resource> _localizer;

        public LocalizationService(IStringLocalizer<Resource> localizer)
        {
            _localizer = localizer;
        }

        public string this[string key] => _localizer[key];

        public void SetCulture(string culture)
        {
            var cultureInfo = new CultureInfo(culture);
            CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
            CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
        }
    }

}
