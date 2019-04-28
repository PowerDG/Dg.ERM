﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DG.ERM.Configuration.Dto;

namespace DG.ERM.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ERMAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
