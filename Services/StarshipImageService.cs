using System.Linq;
using System.Threading.Tasks;

namespace rest_call.Services
{
    public class StarshipImageService : BingImageSearchService
    {
        /// <summary>
        /// Get an Image URL from the Bing Image Search API.
        /// </summary>
        /// <param name="searchTerm"></param>
        /// <returns>An image URL</returns>
        public async Task<string> GetImageUrl(string searchTerm)
        {
            var imageUrl = await SearchBingAsync(searchTerm);

            return imageUrl;
        }

        private async Task<string> SearchBingAsync(string searchTerm)
        {
            var searchOptions = new BingImageSearchOptions
            {
                Aspect = BingImageAspect.Wide,
                Count = 1,
                ImageType = BingImageType.Photo,
                MinHeight = 200
            };
            var query = $"\"Star Wars\" \"{searchTerm}\" -lego -blocks -minecraft";
            var imageResults = await SearchAsync(query, searchOptions);
            var firstImageResult = imageResults.Value.FirstOrDefault();
            var imageUrl = firstImageResult?.ContentUrl;

            return imageUrl;
        }
    }
}
