using Core.Extensions;
using Core.Localization.Holders.Base;
using Newtonsoft.Json;
using System.Reflection;

namespace Core.Localization.Factory
{
    internal class LanguageFactory<TL> where TL : LBase
    {
        public static async Task<T?> InitAsync<T>(Language language) where T : TL
        {
            var l = language is null ? string.Empty : $"{language}.";
            var json = await Assembly.GetExecutingAssembly().ReadResourceAsync($"{l}{typeof(T).Name[1..]}.json");
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static T? Init<T>(Language language) where T : TL
        {
            var l = language is null ? string.Empty : $"{language}.";
            var json = Assembly.GetExecutingAssembly().ReadResourceAsync($"{l}{typeof(T).Name[1..]}.json").Result;
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
