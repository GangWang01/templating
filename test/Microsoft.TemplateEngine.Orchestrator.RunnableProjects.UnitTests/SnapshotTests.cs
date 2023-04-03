﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

#if NET

using Microsoft.Extensions.Logging;
using Microsoft.TemplateEngine.Authoring.TemplateApiVerifier;
using Microsoft.TemplateEngine.Authoring.TemplateVerifier;
using Microsoft.TemplateEngine.TestHelper;
using Microsoft.TemplateEngine.Tests;
using Xunit.Abstractions;

namespace Microsoft.TemplateEngine.Orchestrator.RunnableProjects.UnitTests
{
    [Collection("Verify Tests")]
    public class SnapshotTests : TestBase
    {
        private readonly ILogger _log;

        public SnapshotTests(ITestOutputHelper log)
        {
            _log = new XunitLoggerProvider(log).CreateLogger("TestRun");
        }

        [Fact]
        public Task CanEvaluateJoinSymbolWithRefToDerivedSymbol()
        {
            string templateLocation = GetTestTemplateLocation("TemplateWithGeneratedJoinSymbolWithRefToDerivedSymbol");
            var templateParams = new Dictionary<string, string?>()
            {
                { "NugetToolName", "nuget" }
            };
            string workingDir = TestUtils.CreateTemporaryFolder();

            TemplateVerifierOptions options =
                new TemplateVerifierOptions(templateName: "TestAssets.TemplateGeneratedSymbolWithRefToDerivedSymbol")
                {
                    TemplatePath = templateLocation,
                    OutputDirectory = workingDir,
                    DoNotAppendTemplateArgsToScenarioName = true,
                    DoNotPrependTemplateNameToScenarioName = true,
                    SnapshotsDirectory = "Approvals"
                }
                .WithInstantiationThroughTemplateCreatorApi(templateParams);

            VerificationEngine engine = new VerificationEngine(_log);
            return engine.Execute(options);
        }
    }
}

#endif
