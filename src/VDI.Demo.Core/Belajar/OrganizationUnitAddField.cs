using Abp.Domain.Entities.Auditing;
using Abp.Organizations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VDI.Demo.Belajar
{
    public class OrganizationUnitField : OrganizationUnit
    {
        public string fieldTambahan { get; set; }
    }
}


