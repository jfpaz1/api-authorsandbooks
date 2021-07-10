using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using Newtonsoft.Json;
using AuthorsAndBooks.Models;
using AuthorsAndBooks.BindingModel;

namespace AuthorsAndBooks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        //private readonly IConfiguration _configuration;

        //public AuthorsController(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        private readonly ILogger<AuthorController> _logger;

        public AuthorController(ILogger<AuthorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://fakerestapi.azurewebsites.net/api/v1/Authors");

            var authorsList = JsonConvert.DeserializeObject<List<Author>>(json);

            return Ok(authorsList);
        }

        [Route("GetAuthorByFilter")]
        [HttpGet]
        public async Task<IActionResult> GetAuthorByFilter(string request)
        //public async Task<IActionResult> GetAuthorByFilter([FromBody] BooksFilter request)
        {
            var httpClient = new HttpClient();
            var jsonAuthors = await httpClient.GetStringAsync("https://fakerestapi.azurewebsites.net/api/v1/Authors");

            var authorsList = JsonConvert.DeserializeObject<List<Author>>(jsonAuthors);

            var jsonBooks = await httpClient.GetStringAsync("https://fakerestapi.azurewebsites.net/api/v1/Authors");
            var booksList = JsonConvert.DeserializeObject<List<Author>>(jsonBooks);

            return Ok(authorsList);
        }

        //[HttpGet]
        //public JsonResult Get()
        //{
        //    string query = @"select id, idbook, FirstName, LastName form dbo.author";

        //    DataTable table = new DataTable();
        //    string sqlDataSource = _configuration.GetConnectionString("ConnectionString");
        //    SqlDataReader myReader;
        //    using (SqlConnection myCon = new SqlConnection(sqlDataSource))
        //    {
        //        myCon.Open();
        //        using (SqlCommand myCommand = new SqlCommand(query, myCon))
        //        {
        //            myReader = myCommand.ExecuteReader();
        //            table.Load(myReader);

        //            myReader.Close();
        //            myCon.Close();
        //        }
        //    }

        //    return new JsonResult(table);
        //}
    }
}
