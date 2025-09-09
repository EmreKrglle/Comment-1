using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMDB.Business.Abstract;
using TMDB.Business.Concrete;
using TMDB.Entities;

namespace TMDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Comments : ControllerBase
    {
        private ICommentsServices _commentsServices;
        public Comments(ICommentsServices commentsServices)
        {
            _commentsServices = commentsServices;
            
        }

        [HttpGet]
        public List<Users> Get()
        {
            return _commentsServices.getAllComments();

        }
        [HttpGet("{id}")]
        public Users Get(int id)
        {
            return _commentsServices.getCommentById(id);
        }
        [HttpPost]
        public Users Post([FromBody] Users user)
        {
            return _commentsServices.CreateComments(user);
        }
        [HttpPut]
        public Users Put([FromBody] Users user)
        {
            return _commentsServices.UpdateComments(user);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _commentsServices.DeleteComments(id);
        }

    }
}
