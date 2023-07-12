using Discoteque.Business.IServices;
using Discoteque.Data.Models;

namespace Discoteque.Business.Services;

public class ArtistsService : IArtistsService
{
    public Task<IEnumerable<Artist>> GetArtistsAsync()
    {
        throw new NotImplementedException();
    }

    Task IArtistsService.AddAsync(Artist artist)
    {
        throw new NotImplementedException();
    }

    Task<IEnumerable<Artist>> IArtistsService.GetById(long id)
    {
        throw new NotImplementedException();
    }

    Task IArtistsService.UpdateAsync(Artist artist)
    {
        throw new NotImplementedException();
    }
}