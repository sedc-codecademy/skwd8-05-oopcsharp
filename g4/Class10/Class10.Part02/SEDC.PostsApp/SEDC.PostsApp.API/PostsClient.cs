using SEDC.PostsApp.API.APICustomExceptions;
using SEDC.PostsApp.DataAccess;
using SEDC.PostsApp.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.PostsApp.API
{
    public class PostsClient
    {
        public static List<Post> GetAll(string url)
        {
            // get all URL = "https://api.posts/posts/all"

            try
            {
                if (url == "https://api.posts/posts/all")
                {
                    List<Post> allPosts = Db.Posts();
                    return allPosts;
                }
                else
                {
                    throw new Exception("Something wrong happened !");
                }
            }
            catch (Exception ex)
            {
                throw new BadRequestException("Bad request happened", ex, 400);
            }
        }

        public static Post GetPost(string url)
        {
            // get single post URL = "https://api.posts/posts/1"
            try
            {
                int id = int.Parse(url.Split("/").ToList().LastOrDefault());
                Post post = Db.Posts().SingleOrDefault(p => p.Id == id);

                if (post != null)
                {
                    return post;
                }
                else
                {
                    throw new Exception($"The post with id: {id} was not found !");
                }
            }
            catch (Exception ex)
            {
                throw new NotFoundException("Post not found !", ex, 404);
            }

        }
    }
}
