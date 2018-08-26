using System;
using System.IO;
using NUnit.Framework;
using PutridParrot.Windows;

namespace Tests.PutridParrot.Windows
{
    [TestFixture/*, Ignore("Manual test dependent upon a specific link existing files")*/]
    public class ManualTests
    {
        [Test]
        public void EnsureShortCutMatchesExpectations()
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var link = Path.Combine(desktop, "botframework-emulator.lnk");

            var shortcut = new Shortcut();
            shortcut.Load(link);
            
        }
    }
}
