﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Openddd.MultiTenancy.Dto;

namespace Openddd.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
