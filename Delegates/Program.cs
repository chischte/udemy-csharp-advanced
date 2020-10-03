using System;
using System.Net.WebSockets;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            // Erzeugen des Handlers
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            // Übergeben des Handlers
            processor.Process("photo.jpg", filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Remove red eyes");
        }


    }
}
