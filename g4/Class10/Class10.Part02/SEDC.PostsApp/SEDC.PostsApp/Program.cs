using SEDC.PostsApp.API;
using SEDC.PostsApp.API.APICustomExceptions;
using SEDC.PostsApp.DomainModels;
using System;
using System.Collections.Generic;

namespace SEDC.PostsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string allPostsURL = "https://api.posts/posts/all";
                string singlePostURL = "https://api.posts/posts/1";

                List<Post> allPosts = PostsClient.GetAll(allPostsURL);

                Console.WriteLine("-------------- GET ALL POSTS ------------------");
                allPosts.ForEach(post => Console.WriteLine(post.Title));

                Console.WriteLine("-------------- GET SINGLE POST ------------------");
                Post firstPost = PostsClient.GetPost(singlePostURL);

                Console.WriteLine(firstPost.Title);
            }
            catch (BadRequestException ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"Message: {ex.Message} | StatusCode: {ex.StatusCode}");
            }
            catch (NotFoundException ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Message: {ex.Message} | StatusCode: {ex.StatusCode}");

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ResetColor();
                Console.WriteLine("Press any key to close the app !");
                Console.ReadLine();
            }


        }
    }
}
