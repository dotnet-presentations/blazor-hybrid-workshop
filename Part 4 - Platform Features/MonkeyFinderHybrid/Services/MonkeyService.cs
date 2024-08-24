using System.Net.Http.Json;

namespace MonkeyFinderHybrid.Services;

public class MonkeyService
{
    private readonly HttpClient httpClient;

    public MonkeyService()
    {
        httpClient = new HttpClient();
    }

    List<Monkey> monkeyList = new();

    public async Task<List<Monkey>> GetMonkeys()
    {
        if (monkeyList.Count > 0)
        {
            return monkeyList;
        }

        // Online
        var response = await httpClient.GetAsync("https://www.montemagno.com/monkeys.json");
        if (response.IsSuccessStatusCode)
        {
            var resultMonkeys = await response.Content.ReadFromJsonAsync(MonkeyContext.Default.ListMonkey);

            if (resultMonkeys is not null)
            {
                monkeyList = resultMonkeys;
            }
        }

        // Offline
        //using var stream = await FileSystem.OpenAppPackageFileAsync("monkeydata.json");
        //using var reader = new StreamReader(stream);
        //var contents = await reader.ReadToEndAsync();
        //monkeyList = System.Text.Json.JsonSerializer.Deserialize(contents, MonkeyContext.Default.ListMonkey) ?? new();

        return monkeyList;
    }

    public List<Monkey> AddMonkey(Monkey monkey)
    {
        monkeyList.Add(monkey);
        return monkeyList;
    }

    public Monkey FindMonkeyByName(string name)
    {
        var monkey = monkeyList.FirstOrDefault(m => m.Name == name);

        if (monkey is null)
        {
            throw new Exception("Monkey not found");
        }

        return monkey;
    }
}
