using ConsoleApp.Models.Entitites;

namespace ConsoleApp.Services;

internal class MenuService
{
    private readonly UserService _userService = new();
    private readonly CaseService _caseService = new();


    public async Task<UserEntity> CreateUserAsync()
    {
        var _entity = new UserEntity();
        Console.Clear();
        Console.WriteLine("################## Ny Handläggare ##################");
        Console.Write("Ange förnamn: ");
        _entity.FirstName = Console.ReadLine() ?? "";
        Console.Write("Ange efternamn: ");
        _entity.LastName = Console.ReadLine() ?? "";
        Console.Write("Ange e-postadress: ");
        _entity.Email = Console.ReadLine() ?? "";

        return await _userService.CreateAsync(_entity);
    }



    public async Task MainMenu(int userId)
    {
        Console.Clear();
        Console.WriteLine("################## Huvudmenyn ##################");
        Console.WriteLine("1. Visa alla aktiva ärenden");
        Console.WriteLine("2. Visa alla handläggare");
        Console.WriteLine("3. Skapa nytt ärende");
        Console.Write("Välj ett av ovanstående alternativ: ");
        var option = Console.ReadLine();

        switch(option)
        {
            case "1":
                await ActiveCasesAsync();
                break;

            case "2":
                await HandlersAsync();
                break;

            case "3":
                await NewCaseAsync(userId);
                break;

            default:
                Console.Clear();
                Console.Write("Inget giltigt val angavs.");
                break;
        }
    }


    private async Task ActiveCasesAsync()
    {
        Console.Clear();
        Console.WriteLine("################## Aktiva Ärenden ##################");
        foreach(var _case in await _caseService.GetAllActiveAsync())
        {
            Console.WriteLine($"Ärendenummer: {_case.Id}");
            Console.WriteLine($"Skapad: {_case.Created}");
            Console.WriteLine($"Modifierad: {_case.Modified}");
            Console.WriteLine($"Status: {_case.Status.StatusName}");
            Console.WriteLine("");
        }
    }

    private async Task HandlersAsync()
    {
        Console.Clear();
        Console.WriteLine("################## Handläggare ##################");
        foreach (var _user in await _userService.GetAllAsync())
        {
            Console.WriteLine($"Handläggare-ID: {_user.Id}");
            Console.WriteLine($"Namn: {_user.FirstName} {_user.LastName}");
            Console.WriteLine($"E-postadress: {_user.Email}");
            Console.WriteLine("");
        }
    }

    private async Task NewCaseAsync(int userId)
    {
        var _entity = new CaseEntity { UserId = userId };
        Console.Clear();
        Console.WriteLine("################## Nytt Ärende ##################");
        Console.Write("Ange kundens namn: ");
        _entity.CustomerName = Console.ReadLine() ?? "";
        Console.Write("Ange kundens e-postadress: ");
        _entity.CustomerEmail = Console.ReadLine() ?? "";
        Console.Write("Beskriv ärendet: ");
        _entity.Description = Console.ReadLine() ?? "";

        await _caseService.CreateAsync(_entity);
        await ActiveCasesAsync();
    }
}
