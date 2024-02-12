namespace Core.Localization
{
    public class Language
    {
        public Lang Current = Lang.English;

        public override string ToString() => Current switch
        {
            Lang.English    => "en",
            Lang.Czech      => "cs",
            _ => throw new NotImplementedException()
        };
        
    }
}
