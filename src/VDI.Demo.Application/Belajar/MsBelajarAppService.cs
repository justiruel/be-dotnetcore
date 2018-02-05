using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.UI;
using VDI.Demo.Authorization;
using VDI.Demo.EmployeeServices.MS_BisnisUnits;

namespace VDI.Demo.Belajar
{
    [AbpAuthorize(AppPermissions.Pages_Belajar)]
    public class MSBelajarAppService : DemoAppServiceBase, IMsBelajarAppService
    {
        private readonly IRepository<MS_Belajar> _belajarRepo;
        public MSBelajarAppService(
            IRepository<MS_Belajar> belajarRepo
            )
        {
            _belajarRepo = belajarRepo;
        }

        public async Task CreateCoy(CreateBelajarInput input)
        {

            bool check = (from x in _belajarRepo.GetAll()
                          where x.nama == input.nama
                          select x).Any();
            

            if (!check)
            {

                try
                {
                    var dalne = input.MapTo<MS_Belajar>();
                    await _belajarRepo.InsertAsync(dalne);
                }
                catch (Exception ex)
                {
                    throw new UserFriendlyException( Convert.ToString(ex.Message));
                }

                
            }
            else
            {
                throw new UserFriendlyException("Belajar Already Exist !");
            }
        }

        public ListResultDto<BelajarListDto> getCoy()
        {
            var bljr = _belajarRepo.GetAll().ToList();
            return new ListResultDto<BelajarListDto>(bljr.MapTo<List<BelajarListDto>>());
            //throw new NotImplementedException();
        }
    }
}
