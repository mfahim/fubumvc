using FubuCore;
using FubuMVC.Core;
using FubuMVC.Core.Packaging;
using NUnit.Framework;

namespace FubuMVC.Tests.Packaging
{
    [TestFixture]
    public class ZipFilePackageReaderTester
    {
        [Test]
        public void zip_packages_should_store_content_in_WebContent_subfolder()
        {
            const string packageFolder = @"c:\packageFolder";
            var webContentSubFolder = FileSystem.Combine(packageFolder, FubuMvcPackages.WebContentFolder);
            ZipFilePackageReader.GetContentFolderForPackage(packageFolder).ShouldEqual(webContentSubFolder);
        }
    }
}