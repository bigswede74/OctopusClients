﻿using System.Threading.Tasks;
using Octopus.Cli.Model;
using Octopus.Client;
using Octopus.Client.Model;

namespace Octopus.Cli.Commands
{
    public interface IChannelVersionRuleTester
    {
        Task<ChannelVersionRuleTestResult> Test(IOctopusAsyncRepository repository, ChannelVersionRuleResource rule, string packageVersion);
    }
}