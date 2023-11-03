using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Assignment_1_Jiabao_Ding_n10635074.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}