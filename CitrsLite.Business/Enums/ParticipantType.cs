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
        Government_Office,
        Nursery,
        [Description("Research Institute")]
        Research_Institute,
        [Description("Source Tree Collector")]
        Source_Tree_Collector
    }
}
