using Repositories.Models;
using Repositories.Models.Entities;
using Repositories.Repos;

namespace Repositories.Services;

public class ShowcaseService
{
    private readonly ShowcaseRepository _repo;

    public ShowcaseService(ShowcaseRepository repo)
    {
        _repo = repo;
    }

    public async Task CreateAsync(ShowcaseCreateModel model)
    {
        var showcaseEntity = new ShowcaseEntity
        {
            Title = model.Title,
            Ingress = model.Ingress,
            ImageUrl = model.ImageUrl,
            LinkText = model.LinkText,
            LinkUrl = model.LinkUrl
        };

        await _repo.CreateAsync(showcaseEntity);
    }

    public async Task<ShowcaseModel> GetLatest()
    {
        var showcases = await _repo.GetAllAsync();
        var showcase = showcases.OrderByDescending(x => x.Id).FirstOrDefault();

        return new ShowcaseModel
        {
            Title = showcase!.Title,
            Ingress = showcase.Ingress,
            ImageUrl = showcase.ImageUrl,
            Link = new LinkModel
            {
                Text = showcase!.LinkText!,
                Url = showcase!.LinkUrl!
            }
        };
    }
}
