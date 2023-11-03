using System;
using System.Reflection;

namespace Assignment_1_Jiabao_Ding_n10635074.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}