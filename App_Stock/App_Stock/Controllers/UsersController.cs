using APPSTOCK.Core.Models;
using APPSTOCK.Persistence.Context;
using APPSTOCK.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace App_Stock.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;
        private readonly IRepository _repository;

        [Obsolete]
        private IHostingEnvironment _hostingEnvironment;

        // users hardcoded for simplicity, store in a db with hashed passwords in production applications
        private List<User> _users = new List<User>
        {
            new User { Id = 1, Firstname = "Test", Lastname = "User", Username = "test", Password = "test"},
               
            new User { Id = 2, Firstname = "Normal", Lastname = "User", Username = "user", Password = "user"  }
        };

        [Obsolete]
        public UsersController(IUserService userService, IHostingEnvironment hostingEnvironment, IRepository repository)
        {
            _userService = userService;
            _hostingEnvironment = hostingEnvironment;
            _repository = repository;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(short id)
        {
            List<User> user = await _repository.ExecuteStoredProcedureWithList<User>("test_get_user_by_id", new[] { id.ToString() });
            return Ok(user.FirstOrDefault());
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            var model = JsonConvert.SerializeObject(user);

            System.Xml.Linq.XNode node = JsonConvert.DeserializeXNode(model.ToString(), "Root");

            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("test_create_user", new[] { node.ToString() });

            return Ok(result);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] User user)
        {
            var result = await _repository.ExecuteStoredProcedureWithList<ResponseModel>("test_edit_user", new[] { user.Id.ToString(), user.Firstname, user.Lastname, user.Username, user.Password, user.Role });

            return Ok(result);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<User> Authenticate([FromBody] LoginUser User)
        {
            HttpContext.Session.SetString("Name", "The Doctor");
            //User user = await Task.Run(() => _users.SingleOrDefault(x => x.Username == User.UserName && x.Password == User.Password));

            //var decryptedPassword = CryptoService.Decrypt(User.Password);

            var user = await _repository.ExecuteStoredProcedureWithList<User>("test_get_user", new[] { User.UserName, User.Password });
            // return null if user not found
            if (user.Count == 0)
                return null;

            // authentication successful so return user details without password
            user[0].Password = null;
            var tokenString = await _userService.GenerateJSONWebToken(user.FirstOrDefault());
            user[0].Token = tokenString.ToString();
            return user.FirstOrDefault();
        }

        //[Authorize]
        //  [Authorize(Roles = Role.Admin)]
        [HttpGet("getall")]
        public async Task<IEnumerable<User>> GetAll()
        {
            // return users without passwords
            return await Task.Run(() => _users.Select(x =>
            {
                x.Password = null;
                return x;
            }));
        }

        [HttpPost("upload"), DisableRequestSizeLimit]
        [Obsolete]
        public IActionResult UploadFile()
        {
            try
            {
                //Environment.CurrentDirectory = Configuration.GetConnectionString("PhysicalPath");
                var file = Request.Form.Files[0];
                string folderName = "Uploads";
                string webRootPath = _hostingEnvironment.WebRootPath;
                //string newPath = Path.Combine(webRootPath, folderName);
                string newPath = string.IsNullOrWhiteSpace(webRootPath) ? Path.Combine(Directory.GetCurrentDirectory(), folderName) : Path.Combine(webRootPath, folderName);

                //if (string.IsNullOrWhiteSpace(webRootPath))
                //{
                //    newPath = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                //} 

                if (!Directory.Exists(newPath))
                {
                    Directory.CreateDirectory(newPath);
                }
                string dbPath = string.Empty;
                if (file.Length > 0)
                {
                    string fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    string fullPath = Path.Combine(newPath, fileName);
                    dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }
                return Ok(new { message = "Upload Successful.", path = dbPath });
                //Json(new { message = "Upload Successful.", path = dbPath });
            }
            catch (System.Exception ex)
            {
                return Ok("Upload Failed: " + ex.Message);
                //return Json("Upload Failed: " + ex.Message);
            }
        }

        [HttpPost("uploadasync"), DisableRequestSizeLimit]
        public async Task<IActionResult> UploadFileAsync()
        {
            try
            {
                //Environment.CurrentDirectory = Configuration.GetConnectionString("PhysicalPath");
                //var formCollection = Task.Run(async () => await Request.ReadFormAsync());
                //var file = formCollection.Result.Files.First();
                var formCollection = await Request.ReadFormAsync();
                var file = formCollection.Files.First();
                var folderName = Path.Combine("Resources", "Images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
         
    }
}
