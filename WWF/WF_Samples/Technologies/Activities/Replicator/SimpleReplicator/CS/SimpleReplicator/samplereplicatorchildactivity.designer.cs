//---------------------------------------------------------------------
//  This file is part of the Windows Workflow Foundation SDK Code Samples.
// 
//  Copyright (C) Microsoft Corporation.  All rights reserved.
// 
//This source code is intended only as a supplement to Microsoft
//Development Tools and/or on-line documentation.  See these other
//materials for detailed information regarding Microsoft code samples.
// 
//THIS CODE AND INFORMATION ARE PROVIDED AS IS WITHOUT WARRANTY OF ANY
//KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
//IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
//PARTICULAR PURPOSE.
//---------------------------------------------------------------------

using System;
using System.Workflow.Activities;

namespace Microsoft.Samples.Workflow.SimpleReplicator
{
    public partial class SampleReplicatorChildActivity
    {
        [System.Diagnostics.DebuggerNonUserCode()]
        private void InitializeComponent()
        {
            this.code1 = new System.Workflow.Activities.CodeActivity();
            this.CanModifyActivities = true;

            // 
            // code1
            // 
            this.code1.Name = "code1";
            this.code1.ExecuteCode += new System.EventHandler(this.CodeHandler);
            // 
            // SampleReplicatorChildActivity
            // 
            this.Activities.Add(this.code1);
            this.CanModifyActivities = false;
        }

        
        private CodeActivity code1;

    }
}
