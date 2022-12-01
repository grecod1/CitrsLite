using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Business.Enums
{
    public enum ParticipantType
    {
        [Description("Government Office")]
        GovernmentOffice,
        Nursery,
        [Description("Research Institute")]
        ResearchInstitute,
        [Description("Source Tree Collector")]
        SourceTreeCollector
    }
}
