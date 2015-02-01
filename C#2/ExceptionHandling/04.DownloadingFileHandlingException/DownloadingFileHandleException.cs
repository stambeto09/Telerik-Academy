using System;
using System.IO;
using System.Net;

class DownloadingFileHandleException
{
    static void Main()
    {
        WebClient webClient = new WebClient();
        string url = "http://www.telerik.com/libraries/thumbnails/telerik-logo.sflb";
        string destination="C:\\Users\\akastambata\\Desktop\\ExceptionHandlingHomework\\ExceptionHandlingHomework\\04.DownloadingFileHandlingException\\da.jpg";
        try
        {
            using (webClient)
            {
                webClient.DownloadFile(url,destination);
            }

        }
        catch(ArgumentNullException)
        {
            Console.Error.WriteLine("The adress parameter is null.");
        }
        catch (WebException)
        {
            Console.Error.WriteLine("The file does not exist or file name is null or empty.");
        }
        finally
        {
            Console.WriteLine("Done!");
        }
        
    }
}

