using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ORM.Entities
{
    public class Response
    {
        public Customer Data { get; private set; }
        public int StatusCode { get; private set; }
        public bool IsSuccessful { get; private set; }
        public ErrorDto Error { get; private set; }
        public static Response Success(Customer data, int statusCode)
        {
            return new Response { Data = data, StatusCode = statusCode, IsSuccessful = true };
        }
        public static Response Success(int statusCode)
        {
            return new Response { Data = default, StatusCode = statusCode, IsSuccessful = true };
        }
        public static Response Fail(ErrorDto errorDto, int statusCode)
        {
            return new Response { Error = errorDto, StatusCode = statusCode, IsSuccessful = false };
        }
        public static Response Fail(string errorMessage, int statusCode, bool isShow)
        {
            var errorDto = new ErrorDto(errorMessage, isShow);
            return new Response { Error = errorDto, StatusCode = statusCode, IsSuccessful = false };
        }
    }
}
