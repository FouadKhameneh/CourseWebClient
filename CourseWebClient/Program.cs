using System.Diagnostics;
using System.Net;

Console.WriteLine("1-View list of courses and their basic details\n" +
                  "2-View detailed information about a specific course including instructor and enrolled students\n" +
                  "3-Create a new course\n" +
                  "4-Enroll a student in a course\n" +
                  "5-Update course details\n" +
                  "6-Delete a course\n" +
                  "7-Exit the application\n");

HttpClient httpClient = new HttpClient();

httpClient.BaseAddress = new Uri("https://your-backend-url.com");

while (true)
{
    using (httpClient)
    {
        string stringUserOption = Console.ReadLine();
        int userOption = int.Parse(stringUserOption);

        if (userOption == 1)
        {
            HttpResponseMessage response = await httpClient.GetAsync("api/endpoint");
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                // Process the response body
            }
        }
        else if (userOption == 2)
        {
            
        }
        else if (userOption == 3)
        {
            
        }
        else if (userOption == 4)
        {
            
        }
        else if (userOption == 5)
        {
            
        }
        else if (userOption == 6)
        {
            
        }
        else if (userOption == 7)
        {
            
        }
        else
        {
            Console.WriteLine("Somthing Went Wrong!...\n");
        }

    }
}


