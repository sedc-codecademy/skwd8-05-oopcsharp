using System.Collections.Generic;
using System;
using ExceptionsInner.CustomExceptions;

namespace ExceptionsInner.GocePhotosAPI
{
    public class PhotosGenerator
    {
        public static List<string> GetAllImagesWithLake()
        {

            try
            {
                // Code logic for retrieving all photos with lake background

                string exceptionMessageCode = "10-13i2-2kdiajdsoiej9q9ew10wjdsaidiajwdasd";

                throw new Exception($"Critical error happened with code {exceptionMessageCode}");

                //return new List<string>() { "image1Lake.jpg", "image2Lake2.png" };
            }
            catch (Exception ex)
            {
                throw new GoceAPIException("Error happened when retrieving all lake photos in GoceAPI", ex);
            }
        }
    }
}