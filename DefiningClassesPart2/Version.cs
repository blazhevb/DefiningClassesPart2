using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Method)]
    public class VersionAttribute : Attribute
    {

        private Version version;

        public VersionAttribute (int A, int B)
        {
            this.version = new Version(A, B);
        }

        public virtual string versionInfo
        {
            get { return version.Major.ToString() + "." + version.Minor.ToString(); }
        }
    }
}
