using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Test
{
    public class CustomBuildTask : Task
    {
        public override bool Execute()
        {
            Log.LogMessage(MessageImportance.High, "Custom build task invoked!");
            return true;
        }
    }
}
