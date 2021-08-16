using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ZeemDots.Localization
{
    public static class ZeemDotsLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ZeemDotsConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ZeemDotsLocalizationConfigurer).GetAssembly(),
                        "ZeemDots.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
