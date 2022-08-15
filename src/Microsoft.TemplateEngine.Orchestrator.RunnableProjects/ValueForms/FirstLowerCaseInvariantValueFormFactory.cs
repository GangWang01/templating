// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#nullable enable

using System.Linq;

namespace Microsoft.TemplateEngine.Orchestrator.RunnableProjects.ValueForms
{
    internal class FirstLowerCaseInvariantValueFormFactory : ActionableValueFormFactory
    {
        internal const string FormIdentifier = "firstLowerCaseInvariant";

        internal FirstLowerCaseInvariantValueFormFactory() : base(FormIdentifier) { }

        protected override string? Process(string? value)
        {
            switch (value)
            {
                case null: return null;
                case "": return value;
                default: return value.First().ToString().ToLowerInvariant() + value.Substring(1);
            }
        }
    }
}
