using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Refit;

namespace BlazorApp2.Data
{

    public interface IRemotService 
    {

        [Get("/usuario")]
        public Task<List<Usuario>> GetAllUsuarios();

    }
}
