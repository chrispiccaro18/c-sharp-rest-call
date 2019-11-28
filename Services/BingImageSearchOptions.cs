namespace rest_call.Services
{
    public class BingImageSearchOptions
    {
        /// <summary>
        /// Filter images by the following aspect ratios:
        /// <list type="bullet">
        /// <item>
        /// <term>Square</term>
        /// <description>Return images with standard aspect ratio</description>
        /// </item>
        /// <item>
        /// <term>Wide</term>
        /// <description>Return images with wide screen aspect ratio</description>
        /// </item>
        /// <item>
        /// <term>Tall</term>
        /// <description>Return images with tall aspect ratio</description>
        /// </item>
        /// <item>
        /// <term>All</term>
        /// <description>Do not filter by aspect. Specifying this value is the same as not specifying the <see cref="Aspect"/> parameter.</description>
        /// </item>
        /// </list>
        /// </summary>
        public BingImageAspect Aspect { get; set; }

        /// <summary>
        /// Filter images by the following color options:
        /// <list type="bullet">
        /// <item>
        /// <term>ColorOnly</term>
        /// <description>Return color images</description>
        /// </item>
        /// <item>
        /// <term>Monochrome</term>
        /// <description>Return black and white images</description>
        /// </item>
        /// </list>
        /// Return images with one of the following dominant colors:
        /// <list type="bullet">
        /// <item><description>Black</description></item>
        /// <item><description>Blue</description></item>
        /// <item><description>Brown</description></item>
        /// <item><description>Gray</description></item>
        /// <item><description>Green</description></item>
        /// <item><description>Orange</description></item>
        /// <item><description>Pink</description></item>
        /// <item><description>Purple</description></item>
        /// <item><description>Red</description></item>
        /// <item><description>Teal</description></item>
        /// <item><description>White</description></item>
        /// <item><description>Yellow</description></item>
        /// </list>
        /// </summary>
        public BingImageColor Color { get; set; }

        /// <summary>
        /// <para>The number of images to return in the response. The actual number delivered may be less than requested. The default is 35. The maximum value is 150.</para>
        /// <para>You use this parameter along with the <see cref="Offset"/>offset parameter to page results.For example, if your user interface displays 20 images per page, set <see cref="Count"/> to 20 and <see cref="Offset"/> to 0 to get the first page of results.For each subsequent page, increment <see cref="Offset"/> by 20 (for example, 0, 20, 40).</para>
        /// <para>Use this parameter only with the Image Search API.Do not specify this parameter when calling the Insights, Trending Images, or Web Search APIs.</para>
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// <para>Filter images that have the specified height, in pixels.</para>
        /// <para>You may use this filter with the <see cref="Size"/> filter to return small images that have a height of 150 pixels.</para>
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// Filter images by the following image types:
        /// <list type="bullet">
        /// <item>
        /// <term>AnimatedGif</term>
        /// <description>Return animated gif images</description>
        /// </item>
        /// <item>
        /// <term>AnimatedGifHttps</term>
        /// <description>Return animated gif images that are from an https address</description>
        /// </item>
        /// <item>
        /// <term>Clipart</term>
        /// <description>Return only clip art images</description>
        /// </item>
        /// <item>
        /// <term>Line</term>
        /// <description>Return only line drawings</description>
        /// </item>
        /// <item>
        /// <term>Photo</term>
        /// <description>Return only photographs(excluding line drawings, animated Gifs, and clip art)</description>
        /// </item>
        /// <item>
        /// <term>Shopping</term>
        /// <description>Return only images that contain items where Bing knows of a merchant that is selling the items.This option is valid in the en-US market only.</description>
        /// </item>
        /// <item>
        /// <term>Transparent</term>
        /// <description>Return only images with a transparent background.</description>
        /// </item>
        /// </list>
        /// </summary>
        public BingImageType ImageType { get; set; }

        /// <summary>
        /// <para>Filter images that have a height that is less than or equal to the specified height. Specify the height in pixels.</para>
        /// <para>You may specify this filter and <see cref="MinHeight"/> to filter images within a range of heights.</para>
        /// <para>This filter and the <see cref="Height"/> filter are mutually exclusive.</para>
        /// </summary>
        public long? MaxHeight { get; set; }

        /// <summary>
        /// <para>Filter images that have a width that is less than or equal to the specified width. Specify the width in pixels.</para>
        /// <para>You may specify this filter and <see cref="MinWidth"/> to filter images within a range of widths.</para>
        /// <para>This filter and the <see cref="Width"/> filter are mutually exclusive.</para>
        /// </summary>
        public long? MaxWidth { get; set; }

        /// <summary>
        /// <para>Filter images that have a height that is greater than or equal to the specified height. Specify the height in pixels.</para>
        /// <para>You may specify this filter and <see cref="MaxHeight"/> to filter images within a range of heights.</para>
        /// <para>This filter and the <see cref="Height"/> filter are mutually exclusive.</para>
        /// </summary>
        public long? MinHeight { get; set; }

        /// <summary>
        /// <para>Filter images that have a width that is greater than or equal to the specified width. Specify the width in pixels.</para>
        /// <para>You may specify this filter and <see cref="MaxWidth"/> to filter images within a range of widths.</para>
        /// <para>This filter and the <see cref="Width"/> filter are mutually exclusive.</para>
        /// </summary>
        public long? MinWidth { get; set; }

        /// <summary>
        /// <para>The zero-based offset that indicates the number of images to skip before returning images. The default is 0. The offset should be less than (<see cref="Microsoft.Azure.CognitiveServices.Search.ImageSearch.Models.Images.TotalEstimatedMatches"/> - <see cref="Count"/>).</para>
        /// <para>To page results, use this parameter along with the <see cref="Count"/> parameter. For example, if your user interface displays 20 images per page, set <see cref="Count"/> to 20 and <see cref="Offset"/> to 0 to get the first page of results.For each subsequent page, increment <see cref="Offset"/> by 20 (for example, 0, 20, 40).</para>
        /// <para>It is possible for multiple pages to include some overlap in results.To prevent duplicates, see <see cref="Microsoft.Azure.CognitiveServices.Search.ImageSearch.Models.Images.NextOffset"/>.</para>
        /// <para>Use this parameter only with the Image API. Do not specify this parameter when calling the Trending Images API or the Web Search API.</para>
        /// </summary>
        public long? Offset { get; set; }

        /// <summary>
        /// Filter images by the following sizes:
        /// <list type="bullet">
        /// <item>
        /// <term>Small</term>
        /// <description>Return images that are less than 200x200 pixels</description>
        /// </item>
        /// <item>
        /// <term>Medium</term>
        /// <description>Return images that are greater than or equal to 200x200 pixels but less than 500x500 pixels</description>
        /// </item>
        /// <item>
        /// <term>Large</term>
        /// <description>Return images that are 500x500 pixels or larger</description>
        /// </item>
        /// <item>
        /// <term>Wallpaper</term>
        /// <description>Return wallpaper images.</description>
        /// </item>
        /// <item>
        /// <term>All</term>
        /// <description>Do not filter by size.Specifying this value is the same as not specifying the size parameter.</description>
        /// </item>
        /// </list>
        /// <para>You may use this parameter along with the <see cref="Height"/> or <see cref="Width"/> parameters. For example, you may use <see cref="Height"/> and <see cref="Size"/> to request small images that are 150 pixels tall.</para>
        /// </summary>
        public BingImageSize Size { get; set; }

        /// <summary>
        /// <para>Filter images that have the specified width, in pixels.</para>
        /// <para>You may use this filter with the <see cref="Size"/> filter to return small images that have a width of 150 pixels.</para>
        /// </summary>
        public int? Width { get; set; }
    }

    public enum BingImageAspect
    {
        All,
        Square,
        Wide,
        Tall
    }

    public enum BingImageColor
    {
        All,
        ColorOnly,
        Monochrome,
        Black,
        Blue,
        Brown,
        Gray,
        Green,
        Orange,
        Pink,
        Purple,
        Red,
        Teal,
        White,
        Yellow
    }

    public enum BingImageType
    {
        All,
        AnimatedGif,
        AnimatedGifHttps,
        Clipart,
        Line,
        Photo,
        Shopping,
        Transparent
    }

    public enum BingImageSize
    {
        All,
        Small,
        Medium,
        Large,
        Wallpaper
    }
}
