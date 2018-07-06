﻿//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using Microsoft.PowerShell.EditorServices.Protocol.MessageProtocol;

namespace Microsoft.PowerShell.EditorServices.Protocol.LanguageServer
{
    public class GetCommandsRequest
    {
        public static readonly
            RequestType<string, string, object, object> Type =
            RequestType<string, string, object, object>.Create("powerShell/getCommands");
    }
}
