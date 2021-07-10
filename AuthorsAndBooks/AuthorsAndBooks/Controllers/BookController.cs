using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using AuthorsAndBooks.Models;
using Newtonsoft.Json;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;

namespace AuthorsAndBooks.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        //private readonly IConfiguration _configuration;

        //public BooksController(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}

        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://fakerestapi.azurewebsites.net/api/v1/Books");

            var boksList = JsonConvert.DeserializeObject<List<Book>>(json);

            return Ok(boksList);
        }

        [HttpPost]
        public async Task<IActionResult> GetBookById([FromBody] Book request)
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://fakerestapi.azurewebsites.net/api/v1/Books");

            var boksList = JsonConvert.DeserializeObject<List<Book>>(json);

            return Ok(boksList);
        }

        //[HttpGet]
        //public JsonResult GetBooks()
        //{
        //    string query = @"select id, title, description, pageCount, excerpt, publishDate form dbo.Books";

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
