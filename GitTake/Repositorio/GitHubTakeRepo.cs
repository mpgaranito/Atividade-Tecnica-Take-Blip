using GitTake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace GitTake.Repositorio
{
    public class GitHubTakeRepo
    {
        public async Task<List<CarrosselInfo>> getGitRepos()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");


            var streamTask = client.GetStreamAsync("https://api.github.com/orgs/takenet/repos");
            List<CarrosselInfo> repositories = await JsonSerializer.DeserializeAsync<List<CarrosselInfo>>(await streamTask);

            repositories = repositories.OrderBy(r => r.Criado).ToList();

            List<CarrosselInfo> car = new List<CarrosselInfo>();
            int count = 0;
            foreach(CarrosselInfo r in repositories)
            {

                if(r.Linguagem != null)
                    if (r.Linguagem.Equals("C#"))
                    {
                        car.Add(r);
                        count++;

                        if (count > 5)
                            break;
                    }
            }
          
            return car;

        }
    }
}
