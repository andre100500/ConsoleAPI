using ConsoleAPI.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAPI.RefitClient
{
    public interface IRefitClient
    {
        [Get("/")]
        Task <BucketModel> GetBucketAsync();
    }
}
