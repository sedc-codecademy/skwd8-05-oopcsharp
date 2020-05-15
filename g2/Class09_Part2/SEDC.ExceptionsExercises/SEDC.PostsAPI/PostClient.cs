using SEDC.DataAccess;
using SEDC.DomainModels;
using SEDC.PostsAPI.APIExceptionHandlers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.PostsAPI
{
    public class PostClient
    {
        public static List<Post> GetAll(string url)
        {
            try
            {
                if (url == "https://api.posts/posts/all")
                {
                    List<Post> allPosts = Db.Posts();
                    return allPosts;
                }
                else
                {
                    throw new Exception("Something wrong happened!");
                }
            }
            catch (Exception ex)
            {
                //TODO: Implement custom exception for handling bad requests
                throw new BadRequestException("Bad request", ex.InnerException, 400);
            }
        }

        public static Post Get(string url)
        {
            // First post url: https://api.posts/posts/1
            try
            {
                int id = Convert.ToInt32(url.Split('/').ToList().TakeLast(1).FirstOrDefault());
                Post post = Db.Posts().Where(x => x.Id == id).SingleOrDefault();

                if (post != null)
                {
                    return post;
                }
                else
                {
                    throw new Exception($"No post with Id: {id} found!");
                }
            }
            catch (Exception ex)
            {
                //TODO: Implement custom exception for page not found 
                throw new NotFoundException("Resource not found", ex.InnerException, 404);
            }
        }
    }
}
