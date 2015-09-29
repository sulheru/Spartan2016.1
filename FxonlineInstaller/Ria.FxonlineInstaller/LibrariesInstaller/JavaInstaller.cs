﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ria.FxonlineInstaller.LibrariesInstaller
{
    public class JavaInstaller : AbstractLibraryInstaller
    {

        public override string AppName
        { get { return "Java"; } }

        public override string RegistryLocalKey
        { get { return "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\javaws.exe"; } }

        protected override bool BeforeInstall() { return true; }
        protected override void AfterInstall() { }

        public override string AppURL
        {
            get { return "http://javadl.sun.com/webapps/download/AutoDL?BundleId=109716"; }
        }
    }
}