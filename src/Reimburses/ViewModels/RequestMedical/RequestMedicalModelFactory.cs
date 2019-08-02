using System;
using Reimburses.Data.Abstractions;
using ExtCore.Data.Abstractions;

namespace Reimburses.ViewModels. RequestMedical
{
    class  RequestMedicalModelFactory
    {
        public  RequestMedicalModelFactory()
        {
        }

        internal  RequestMedicalIndexViewModel LoadAll(IStorage storage, int page, int size)
        {
            var  requestMedicalRepo = storage.GetRepository<IRequestMedicalRepository>();

            var queryRequestMedical = requestMedicalRepo.Query;

            return new  RequestMedicalIndexViewModel( requestMedicalRepo.All(queryRequestMedical, page, size));
        }
    }
}
