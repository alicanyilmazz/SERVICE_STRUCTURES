using Microsoft.Extensions.DependencyInjection;
using ORM.Entities;
using ORM.IDalOperations;
using ORM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.DalOperations
{
    public class OracleCustomerDal : ICustomerDal
    {
        private static readonly LoggerHandler _provider = NLogConfig._serviceProvider.GetRequiredService<LoggerHandler>();
        public Response Add(Customer Entity)
        {
            try
            {
                Console.WriteLine($"Oracle : {Entity.Name} added.");
            }
            catch (Exception ex)
            {
                _provider.LogError(ex.Message, ex);
                return Response.Fail(ex.Message, 500, false);
            }
            finally
            {
                _provider.LogInfo("Success");
            }
            return Response.Success(Entity, 200);
        }

        public Response Delete(Customer Entity)
        {
            try
            {
                Console.WriteLine($"Oracle : {Entity.Name} deleted.");
            }
            catch (Exception ex)
            {
                _provider.LogError(ex.Message, ex);
                return Response.Fail(ex.Message, 500, false);
            }
            finally
            {
                _provider.LogInfo("Success");
            }
            return Response.Success(Entity, 200);
        }

        public Response Update(Customer Entity)
        {
            try
            {
                Console.WriteLine($"Oracle : {Entity.Name} updated.");
            }
            catch (Exception ex)
            {
                _provider.LogError(ex.Message, ex);
                return Response.Fail(ex.Message, 500, false);
            }
            finally
            {
                _provider.LogInfo("Success");
            }
            return Response.Success(Entity, 200);
        }
    }
}
