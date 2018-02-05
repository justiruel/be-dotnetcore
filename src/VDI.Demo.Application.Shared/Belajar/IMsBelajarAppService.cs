using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VDI.Demo.EmployeeServices.MS_BisnisUnits;

namespace VDI.Demo.Belajar
{
    public interface IMsBelajarAppService : IApplicationService
    {
        ListResultDto<BelajarListDto> getCoy();
        Task CreateCoy(CreateBelajarInput input);

        /*ListResultDto<BisnisUnitListDto> GetBisnisUnitById(int Id);
        ListResultDto<BisnisUnitListDto> GetAllBisnisUnit();
        Task CreateBisnisUnit(CreateBisnisUnitInput input);
        Task DeleteBisnisUnit(EntityDto input);
        Task UpdateBisnisUnit(CreateBisnisUnitInput input);*/
    }
}
