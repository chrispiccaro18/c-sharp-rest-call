using System;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Search.ImageSearch;
using Microsoft.Azure.CognitiveServices.Search.ImageSearch.Models;

namespace rest_call.Services
{
    public class BingImageSearchService
    {
        private readonly ImageSearchClient _client;

        protected BingImageSearchService()
        {
            const string subscriptionKey = "70c508d2c10147f79d9d260042ade225";
            var credentials = new ApiKeyServiceClientCredentials(subscriptionKey);
            _client = new ImageSearchClient(credentials);
        }

        protected async Task<Images> SearchAsync(string searchTerm, BingImageSearchOptions searchOptions = null)
        {
            Images imageResults;

            if (searchOptions == null)
            {
                imageResults = await _client.Images.SearchAsync(searchTerm);
            }
            else
            {
                var aspect = Enum.GetName(typeof(BingImageAspect), searchOptions.Aspect);
                var color = searchOptions.Color == BingImageColor.All
                    ? null
                    : Enum.GetName(typeof(BingImageColor), searchOptions.ImageType);
                var imageType = searchOptions.ImageType == BingImageType.All
                    ? null
                    : Enum.GetName(typeof(BingImageType), searchOptions.ImageType);
                var size = Enum.GetName(typeof(BingImageSize), searchOptions.Size);

                imageResults = await _client.Images.SearchAsync(
                    searchTerm,
                    aspect: aspect,
                    color: color,
                    count: searchOptions.Count,
                    height: searchOptions.Height,
                    imageType: imageType,
                    maxHeight: searchOptions.MaxHeight,
                    maxWidth: searchOptions.MaxWidth,
                    minHeight: searchOptions.MinHeight,
                    minWidth: searchOptions.MinWidth,
                    offset: searchOptions.Offset,
                    size: size,
                    width: searchOptions.Width
                );
            }

            return imageResults;
        }
    }
}
