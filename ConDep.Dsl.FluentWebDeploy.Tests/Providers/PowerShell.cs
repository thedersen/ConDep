using ConDep.Dsl.FluentWebDeploy;
using NUnit.Framework;

namespace ConDep.WebDeploy.Dsl.Tests.Providers
{
    public class when_using_PowerShell_provider : ProviderTestFixture<PowerShellProvider>
    {
        protected override void When()
        {
            Providers.PowerShell(DestinationPath);
        }

        [Test]  
        public void should_not_have_source_path()
        {
            Assert.That(Provider.SourcePath, Is.Null.Or.Empty);
        }

        [Test]
        public void should_have_valid_destination_path()
        {
            Assert.That(DestinationPath, Is.EqualTo(Provider.DestinationPath));
        }

        public string DestinationPath
        {
            get { return "get-date"; }
        }

    }
}