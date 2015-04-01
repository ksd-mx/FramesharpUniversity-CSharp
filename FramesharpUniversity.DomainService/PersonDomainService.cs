using Framesharp.Core.Interfaces;
using Framesharp.DomainService;
using System.Collections.Generic;
using FramesharpUniversity.Domain;
using FramesharpUniversity.DomainService.Interfaces;
using FramesharpUniversity.Repository.Interfaces;

namespace FramesharpUniversity.DomainService
{
    public class PersonDomainService : CrudDomainService<Domain.Person, IPersonRepository>, IPersonDomainService
    {
        public PersonDomainService(IOperationCallContext context) : 
                base(context)
        {
        }
    }
}