using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    [Version(2, 11)]
    class SampleClass
    {
        public void DisplayVersion(Type t)
        {
            VersionAttribute MyAttribute = (VersionAttribute)Attribute.GetCustomAttribute(t, typeof(VersionAttribute));
            Console.WriteLine(MyAttribute.versionInfo);
        }
    }
}
