using Newtonsoft.Json;
using System.Net;
using WilianPepinos_P3.Models;
namespace WilianPepinos_P3.Views;

public partial class Page_Wp : ContentPage
{
    public Page_Wp()
    {
        InitializeComponent();
    }
    public async void Button_cliked(object sender, EventArgs e)
    {
        var request = new HttpRequestMessage();
        request.RequestUri = new Uri("https://jsonplaceholder.typicode.com/posts");
        request.Method = HttpMethod.Get;
        request.Headers.Add("Accept", "application/json");

        var client = new HttpClient();

        HttpResponseMessage response = await client.SendAsync(request);
        if (response.StatusCode == HttpStatusCode.OK)
        {
            String content = await response.Content.ReadAsStringAsync();
            var resultado = JsonConvert.DeserializeObject<List<Shoes>>(content);
            ListaDemo.ItemsSource = resultado;
        }
    
        }
}
