using ExceptionsInner.GocePhotosAPI;
using System.Collections.Generic;
using System;

namespace ExceptionsInner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Global error handling mechanism
            List<string> images = new List<string>();
            try
            {
                images = PhotosGenerator.GetAllImagesWithLake();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.InnerException.Message);
                // I will show here default 3 photos of lake somewhere

                // if GOCEAPI exception happened => show 3 default photos with lake background
                Console.WriteLine(ex.Message);
            }

            foreach (var image in images)
            {
                Console.WriteLine(image);
            }

            Console.ReadLine();
        }
    }
}