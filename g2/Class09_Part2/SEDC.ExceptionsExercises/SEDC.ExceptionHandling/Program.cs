using SEDC.DomainModels;
using SEDC.PostsAPI;
using SEDC.PostsAPI.APIExceptionHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace SEDC.ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Take() Explained
            //List<string> names = new List<string>
            //{
            //    "Martin",
            //    "Ivo",
            //    "Dejan",
            //    "Stefan",
            //    "Irina",
            //    "Mimi",
            //    "Marko",
            //};

            //var namesStartWithM = names.Where(x => x.StartsWith('M'))
            //                                    .OrderByDescending(x => x)
            //                                    .Take(1)
            //                                    .FirstOrDefault();
            //Console.WriteLine(namesStartWithM);
            #endregion

            try
            {
                string allPostsUrl = "https://api.posts/posts/all";
                string singlePostUrl = "https://api.posts/posts/martin";

                List<Post> allPosts = PostClient.GetAll(allPostsUrl);

                Post singlePost = PostClient.Get(singlePostUrl);

                allPosts.ForEach(x => Console.WriteLine(x.Title));
                Console.WriteLine("________________________________");
                Console.WriteLine($"Single post: {singlePost.Title}");
            }
            catch (BadRequestException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Message: {ex.Message} | StatusCode: {ex.StatusCode}");
            }
            catch (NotFoundException ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Message: {ex.Message} | StatusCode: {ex.StatusCode}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }


            Console.WriteLine("This will work after the exception is thrown!");

            Console.ReadLine();
        }
    }
}
