using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    //public record CompanyForCreationDto(Guid Id, string Name, string FullAddress);


    //the init here is for xml differentiating or [Serializable]
    //[Serializable]
    public record CompanyDto
    {
        public Guid Id { get; init; }
        public string? Name { get; init; }
        public string? FullAddress { get; init; }
    }    
}