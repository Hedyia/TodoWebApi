
namespace TodoApp
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class Service
    {
        private string _url = "http://todoapp-u1.azurewebsites.net/api/Todoes";
        public async Task<ObservableCollection<Todo>> GetData()
        {
            var _client = new HttpClient();
            var json = await _client.GetStringAsync(_url);
            var request = JsonConvert.DeserializeObject<List<Todo>>(json);
            var _todoes = new ObservableCollection<Todo>(request);
            return _todoes;
        }
    }
}
