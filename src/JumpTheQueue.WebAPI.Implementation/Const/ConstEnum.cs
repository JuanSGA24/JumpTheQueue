using System;
using System.Collections.Generic;
using System.Text;

namespace JumpTheQueue.WebAPI.Implementation.Const
{

    public enum QueueStatus
    {
        NotStarted,
        Waiting,
        Attending,
        Attended,
        Skipped
    }

    public enum Role
    {
        Owner,
        Employee
    }


}
